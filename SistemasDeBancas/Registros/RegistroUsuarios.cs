using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace SistemasDeBancas
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            NombreTextBox.ReadOnly = false;
            ClaveTextBox.ReadOnly = false;
            GuardarButton.Enabled = true;
            EliminarButton.Enabled = true;
        }

        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            if (!Validar())
            {
                MessageBox.Show("Complete los datos");
                return;
            }

            usuario = LlenarClase();

            if (UsuariosBLL.Guardar(usuario))
            {
                NuevoButton.PerformClick();

                MessageBox.Show("Guardado.....");
            }
        }


        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "Debe introducir el nombre!!!");
                retorno = false;
            }
            else
            if (string.IsNullOrEmpty(ClaveTextBox.Text))
            {
                errorProvider2.SetError(ClaveTextBox, "Debe introducir una Contraseña!!!");
                retorno = false;
            }
            return retorno;
        }
        private Usuarios LlenarClase()
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioID = Utilidades.Toint(UsuarioIDTextBox.Text);
            usuario.Nombre = NombreTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            return usuario;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
