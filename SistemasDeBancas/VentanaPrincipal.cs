using SistemasDeBancas;
using SistemasDeBancas.Registros;
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
            timer1.Enabled = true;


        }
       

        private void AbrirVentas_Click(object sender, EventArgs e)
        {

           
            
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

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            

            
        }

        private void SalirButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void UsuarioButton_Click_1(object sender, EventArgs e)
        {
            
            RegistroUsuarios rg = new RegistroUsuarios();
            rg.Visible = true;
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Monto.Clear();
            Numero.Clear();
            LoteriasComboBox.SelectedItem = 0;
            Total.Clear();
            TotalPale.Clear();
            TotalQuiniela.Clear();
            TotalTripleta.Clear();
            Quiniela.Clear();
            Pale.Clear();
            Tripleta.Clear();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {

            if ((Numero.Text).Length >= 0 && (Numero.Text).Length < 3)
            {
                Quiniela.Items.Add(Monto.Text +"   " + Numero.Text );
                              
            }
            else
            if ((Numero.Text).Length >= 3 && (Numero.Text).Length < 5)
            {
                Pale.Items.Add(Monto.Text,3);
                Pale.Items.Add(Numero.Text,3);

            }
            else
            if ((Numero.Text).Length >= 5 && (Numero.Text).Length < 7)
            {
                Tripleta.Items.Add(Monto.Text,3);
                Tripleta.Items.Add(Numero.Text,3);
            }
            else
                MessageBox.Show("Error en el formato");


            

        }

        private int Length(string text)
        {
            throw new NotImplementedException();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToString();
        }

        private void Loteriabutton_Click(object sender, EventArgs e)
        {
            var RL = new Registros.RegistrarLoteria();
            RL.Visible = true;
        }
    }
}
