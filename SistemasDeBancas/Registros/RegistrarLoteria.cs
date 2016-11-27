using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemasDeBancas.Registros
{
    public partial class RegistrarLoteria : Form
    {
        public RegistrarLoteria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HabilitarRegistroLoteria();
            LimpiarCamposRegistroLoteria();

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            
        }
        private void HabilitarRegistroLoteria()
        {
           
            NombretextBox.Enabled = true;
            MontoPrimeratextBox.Enabled = true;
            MontoTerceratextBox.Enabled = true;
            MontoPale2textBox.Enabled = true;
            MontoTripleta2textBox.Enabled = true;
            MaximoPaletextBox.Enabled = true;
            MontoSegundatextBox.Enabled = true;
            MontoPale1textBox.Enabled = true;
            MontoTripleta1textBox.Enabled = true;
            MaximoQuinielatextBox.Enabled = true;
            MaximoTripletatextBox.Enabled = true;
            HoraApecturadateTimePicker.Enabled = true;
            HoraCierredateTimePicker.Enabled = true;
            GuardarButton.Enabled = true;
            
            
        }
        private void LimpiarCamposRegistroLoteria()
        {
            IdLoteriatextBox.Clear();
            NombretextBox.Clear();
            MontoPrimeratextBox.Clear();
            MontoTerceratextBox.Clear();
            MontoPale2textBox.Clear();
            MontoTripleta2textBox.Clear();
            MaximoPaletextBox.Clear();
            MontoSegundatextBox.Clear();
            MontoPale1textBox.Clear();
            MontoTripleta1textBox.Clear();
            MaximoQuinielatextBox.Clear();
            MaximoTripletatextBox.Clear();



        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            //Loteria.Nombre

            //if (UsuariosBLL.Guardar(usuario))
            //{
               
            //}

            //else
            //    MessageBox.Show("Error al guardar");
        }
    }
}
