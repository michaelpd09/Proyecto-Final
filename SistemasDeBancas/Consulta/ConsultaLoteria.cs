using BLL;
using Entidades;
using SistemasDeBancas.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemasDeBancas.Consulta
{
    public partial class ConsultaLoteria : Form
    {
        public ConsultaLoteria()
        {
            InitializeComponent();
        }

        public List<Loterias> lista = new List<Loterias>();

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            this.DatosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.MultiSelect = false;

            if (CamposComboBox.SelectedItem.ToString() == "UsuarioID")
            {
                if (!String.IsNullOrEmpty(FiltroTextBox.Text))
                    lista = LoteriasBLL.GetListaLoteriaID(Utilidades.ToInt(FiltroTextBox.Text));
                else
                    lista = LoteriasBLL.GetLista();
            }
            else
            if (CamposComboBox.SelectedItem.ToString() == "Nombre")
            {
                if (!String.IsNullOrEmpty(FiltroTextBox.Text))
                    lista = LoteriasBLL.GetListaLoterias(FiltroTextBox.Text);
                else
                    lista = LoteriasBLL.GetLista();
            }
            else
            {

                lista = LoteriasBLL.GetLista();

            }
            DatosDataGridView.DataSource = lista;
            EliminarButton.Enabled = true;
            EditarButton.Enabled = true;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            var registrarLoteria = new RegistrarLoteria();
            registrarLoteria.Visible = true;
            Close();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.CurrentRow != null)
            {
                DialogResult dialogo = MessageBox.Show("Desea Borrar el Querido Usuario", "Borrarando Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    int LoteriaID = Convert.ToInt32(DatosDataGridView.CurrentRow.Cells["UsuarioID"].Value);
                    LoteriasBLL.Eliminar(LoteriaID);
                    lista = LoteriasBLL.GetLista();
                }
            }
            else
            {
                return;

            }
            DatosDataGridView.DataSource = lista;
        }
    }
}
