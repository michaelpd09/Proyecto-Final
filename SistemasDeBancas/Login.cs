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
    
    public partial class Login : Form
    {
        
        public Login()
        {
            
            InitializeComponent();
           
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            
          
            Close();            
            
        }
        
    }
}
