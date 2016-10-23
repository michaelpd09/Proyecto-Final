using SistemasDeBancas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemasDeBancas
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();   
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Tripleta_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

           


        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
           
            MaximizeBox = false;
            

        }
       

        private void AbrirVentas_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Show();
            
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ya Gurado papa!!!!!!!");
        }

        private void UsuarioButton_Click(object sender, EventArgs e)
        {
            RegistroUsuarios rg = new RegistroUsuarios();
            rg.Visible = true;
        }
    }
}
