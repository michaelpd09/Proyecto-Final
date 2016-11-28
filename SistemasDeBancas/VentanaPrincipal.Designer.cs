namespace SistemasDeBancas
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.VentagroupBox = new System.Windows.Forms.GroupBox();
            this.NombreLoteriatextBox = new System.Windows.Forms.TextBox();
            this.IdLoteriatextBox = new System.Windows.Forms.TextBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.NumerotextBox = new System.Windows.Forms.TextBox();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumerogroupBox = new System.Windows.Forms.GroupBox();
            this.DatosdataGridView = new System.Windows.Forms.DataGridView();
            this.Hora = new System.Windows.Forms.Label();
            this.UsuarioSistema = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.AnularButton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.ReimprimirButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.UsuarioButton = new System.Windows.Forms.Button();
            this.ReporteButton = new System.Windows.Forms.Button();
            this.OpcionesgroupBox = new System.Windows.Forms.GroupBox();
            this.Loteriabutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.VentagroupBox.SuspendLayout();
            this.NumerogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).BeginInit();
            this.OpcionesgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // VentagroupBox
            // 
            this.VentagroupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VentagroupBox.BackgroundImage")));
            this.VentagroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VentagroupBox.Controls.Add(this.NombreLoteriatextBox);
            this.VentagroupBox.Controls.Add(this.IdLoteriatextBox);
            this.VentagroupBox.Controls.Add(this.Agregarbutton);
            this.VentagroupBox.Controls.Add(this.NumerotextBox);
            this.VentagroupBox.Controls.Add(this.MontotextBox);
            this.VentagroupBox.Controls.Add(this.label7);
            this.VentagroupBox.Controls.Add(this.label3);
            this.VentagroupBox.Controls.Add(this.label2);
            this.VentagroupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.VentagroupBox.Location = new System.Drawing.Point(18, 13);
            this.VentagroupBox.Name = "VentagroupBox";
            this.VentagroupBox.Size = new System.Drawing.Size(567, 102);
            this.VentagroupBox.TabIndex = 32;
            this.VentagroupBox.TabStop = false;
            this.VentagroupBox.Text = "Venta";
            // 
            // NombreLoteriatextBox
            // 
            this.NombreLoteriatextBox.AccessibleName = "";
            this.NombreLoteriatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLoteriatextBox.Location = new System.Drawing.Point(169, 10);
            this.NombreLoteriatextBox.Name = "NombreLoteriatextBox";
            this.NombreLoteriatextBox.Size = new System.Drawing.Size(376, 38);
            this.NombreLoteriatextBox.TabIndex = 44;
            // 
            // IdLoteriatextBox
            // 
            this.IdLoteriatextBox.AccessibleName = "";
            this.IdLoteriatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLoteriatextBox.Location = new System.Drawing.Point(61, 10);
            this.IdLoteriatextBox.Name = "IdLoteriatextBox";
            this.IdLoteriatextBox.Size = new System.Drawing.Size(100, 38);
            this.IdLoteriatextBox.TabIndex = 43;
            this.IdLoteriatextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.AccessibleName = "";
            this.Agregarbutton.BackColor = System.Drawing.Color.Transparent;
            this.Agregarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Agregarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbutton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregarbutton.Location = new System.Drawing.Point(401, 52);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(144, 39);
            this.Agregarbutton.TabIndex = 28;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = false;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // NumerotextBox
            // 
            this.NumerotextBox.AccessibleName = "";
            this.NumerotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumerotextBox.Location = new System.Drawing.Point(240, 53);
            this.NumerotextBox.Name = "NumerotextBox";
            this.NumerotextBox.Size = new System.Drawing.Size(155, 38);
            this.NumerotextBox.TabIndex = 37;
            // 
            // MontotextBox
            // 
            this.MontotextBox.AccessibleName = "";
            this.MontotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontotextBox.Location = new System.Drawing.Point(60, 55);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.Size = new System.Drawing.Size(100, 38);
            this.MontotextBox.TabIndex = 35;
            this.MontotextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Monto_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(3, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Loteria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(169, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Monto";
            // 
            // NumerogroupBox
            // 
            this.NumerogroupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NumerogroupBox.BackgroundImage")));
            this.NumerogroupBox.Controls.Add(this.DatosdataGridView);
            this.NumerogroupBox.Controls.Add(this.Hora);
            this.NumerogroupBox.Controls.Add(this.UsuarioSistema);
            this.NumerogroupBox.Controls.Add(this.label9);
            this.NumerogroupBox.Controls.Add(this.TotaltextBox);
            this.NumerogroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NumerogroupBox.Location = new System.Drawing.Point(18, 119);
            this.NumerogroupBox.Name = "NumerogroupBox";
            this.NumerogroupBox.Size = new System.Drawing.Size(567, 401);
            this.NumerogroupBox.TabIndex = 33;
            this.NumerogroupBox.TabStop = false;
            this.NumerogroupBox.Text = "Detalle";
            // 
            // DatosdataGridView
            // 
            this.DatosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView.Location = new System.Drawing.Point(11, 19);
            this.DatosdataGridView.Name = "DatosdataGridView";
            this.DatosdataGridView.Size = new System.Drawing.Size(534, 298);
            this.DatosdataGridView.TabIndex = 36;
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.BackColor = System.Drawing.Color.Transparent;
            this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Hora.Location = new System.Drawing.Point(227, 327);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(0, 20);
            this.Hora.TabIndex = 35;
            this.Hora.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // UsuarioSistema
            // 
            this.UsuarioSistema.AutoSize = true;
            this.UsuarioSistema.BackColor = System.Drawing.Color.Transparent;
            this.UsuarioSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioSistema.Location = new System.Drawing.Point(110, 375);
            this.UsuarioSistema.Name = "UsuarioSistema";
            this.UsuarioSistema.Size = new System.Drawing.Size(0, 20);
            this.UsuarioSistema.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(7, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "Usuario:";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.AccessibleName = "";
            this.TotaltextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.TotaltextBox.Enabled = false;
            this.TotaltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotaltextBox.ForeColor = System.Drawing.Color.White;
            this.TotaltextBox.Location = new System.Drawing.Point(401, 319);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(144, 44);
            this.TotaltextBox.TabIndex = 31;
            // 
            // GuardarButton
            // 
            this.GuardarButton.AccessibleName = "";
            this.GuardarButton.BackColor = System.Drawing.Color.Transparent;
            this.GuardarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GuardarButton.BackgroundImage")));
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ForeColor = System.Drawing.Color.Blue;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.Location = new System.Drawing.Point(35, 27);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(136, 48);
            this.GuardarButton.TabIndex = 21;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = false;
            // 
            // AnularButton
            // 
            this.AnularButton.AccessibleName = "";
            this.AnularButton.BackColor = System.Drawing.Color.Transparent;
            this.AnularButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AnularButton.BackgroundImage")));
            this.AnularButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AnularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnularButton.ForeColor = System.Drawing.Color.Blue;
            this.AnularButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnularButton.Location = new System.Drawing.Point(35, 201);
            this.AnularButton.Name = "AnularButton";
            this.AnularButton.Size = new System.Drawing.Size(136, 48);
            this.AnularButton.TabIndex = 22;
            this.AnularButton.Text = "Anular";
            this.AnularButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AnularButton.UseVisualStyleBackColor = false;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.AccessibleName = "";
            this.Cancelarbutton.BackColor = System.Drawing.Color.Transparent;
            this.Cancelarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancelarbutton.BackgroundImage")));
            this.Cancelarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cancelarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelarbutton.ForeColor = System.Drawing.Color.Blue;
            this.Cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbutton.Location = new System.Drawing.Point(35, 85);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(136, 48);
            this.Cancelarbutton.TabIndex = 23;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbutton.UseVisualStyleBackColor = false;
            this.Cancelarbutton.Click += new System.EventHandler(this.Nuevobutton_Click_1);
            // 
            // ReimprimirButton
            // 
            this.ReimprimirButton.AccessibleName = "";
            this.ReimprimirButton.BackColor = System.Drawing.Color.Transparent;
            this.ReimprimirButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReimprimirButton.BackgroundImage")));
            this.ReimprimirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReimprimirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReimprimirButton.ForeColor = System.Drawing.Color.Blue;
            this.ReimprimirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReimprimirButton.Location = new System.Drawing.Point(35, 143);
            this.ReimprimirButton.Name = "ReimprimirButton";
            this.ReimprimirButton.Size = new System.Drawing.Size(136, 48);
            this.ReimprimirButton.TabIndex = 24;
            this.ReimprimirButton.Text = "Reimprimir";
            this.ReimprimirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReimprimirButton.UseVisualStyleBackColor = false;
            // 
            // SalirButton
            // 
            this.SalirButton.BackColor = System.Drawing.Color.Transparent;
            this.SalirButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalirButton.BackgroundImage")));
            this.SalirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SalirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirButton.ForeColor = System.Drawing.Color.Blue;
            this.SalirButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SalirButton.Location = new System.Drawing.Point(35, 433);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(136, 48);
            this.SalirButton.TabIndex = 25;
            this.SalirButton.Text = "Salir";
            this.SalirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SalirButton.UseVisualStyleBackColor = false;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click_1);
            // 
            // UsuarioButton
            // 
            this.UsuarioButton.AccessibleName = "";
            this.UsuarioButton.BackColor = System.Drawing.Color.Transparent;
            this.UsuarioButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UsuarioButton.BackgroundImage")));
            this.UsuarioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UsuarioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioButton.ForeColor = System.Drawing.Color.Blue;
            this.UsuarioButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.UsuarioButton.Location = new System.Drawing.Point(35, 375);
            this.UsuarioButton.Name = "UsuarioButton";
            this.UsuarioButton.Size = new System.Drawing.Size(136, 48);
            this.UsuarioButton.TabIndex = 26;
            this.UsuarioButton.Text = "Usuarios";
            this.UsuarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UsuarioButton.UseVisualStyleBackColor = false;
            this.UsuarioButton.Click += new System.EventHandler(this.UsuarioButton_Click_1);
            // 
            // ReporteButton
            // 
            this.ReporteButton.AccessibleName = "";
            this.ReporteButton.BackColor = System.Drawing.Color.Transparent;
            this.ReporteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReporteButton.BackgroundImage")));
            this.ReporteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReporteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteButton.ForeColor = System.Drawing.Color.Blue;
            this.ReporteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReporteButton.Location = new System.Drawing.Point(35, 259);
            this.ReporteButton.Name = "ReporteButton";
            this.ReporteButton.Size = new System.Drawing.Size(136, 48);
            this.ReporteButton.TabIndex = 27;
            this.ReporteButton.Text = "Reportes";
            this.ReporteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReporteButton.UseVisualStyleBackColor = false;
            // 
            // OpcionesgroupBox
            // 
            this.OpcionesgroupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpcionesgroupBox.BackgroundImage")));
            this.OpcionesgroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpcionesgroupBox.Controls.Add(this.Loteriabutton);
            this.OpcionesgroupBox.Controls.Add(this.ReporteButton);
            this.OpcionesgroupBox.Controls.Add(this.UsuarioButton);
            this.OpcionesgroupBox.Controls.Add(this.ReimprimirButton);
            this.OpcionesgroupBox.Controls.Add(this.SalirButton);
            this.OpcionesgroupBox.Controls.Add(this.Cancelarbutton);
            this.OpcionesgroupBox.Controls.Add(this.AnularButton);
            this.OpcionesgroupBox.Controls.Add(this.GuardarButton);
            this.OpcionesgroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpcionesgroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpcionesgroupBox.Location = new System.Drawing.Point(617, 13);
            this.OpcionesgroupBox.Name = "OpcionesgroupBox";
            this.OpcionesgroupBox.Size = new System.Drawing.Size(200, 504);
            this.OpcionesgroupBox.TabIndex = 34;
            this.OpcionesgroupBox.TabStop = false;
            this.OpcionesgroupBox.Text = "Opciones";
            // 
            // Loteriabutton
            // 
            this.Loteriabutton.AccessibleName = "";
            this.Loteriabutton.BackColor = System.Drawing.Color.Transparent;
            this.Loteriabutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Loteriabutton.BackgroundImage")));
            this.Loteriabutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Loteriabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loteriabutton.ForeColor = System.Drawing.Color.Blue;
            this.Loteriabutton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Loteriabutton.Location = new System.Drawing.Point(35, 317);
            this.Loteriabutton.Name = "Loteriabutton";
            this.Loteriabutton.Size = new System.Drawing.Size(136, 48);
            this.Loteriabutton.TabIndex = 28;
            this.Loteriabutton.Text = "Loterias";
            this.Loteriabutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Loteriabutton.UseVisualStyleBackColor = false;
            this.Loteriabutton.Click += new System.EventHandler(this.Loteriabutton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // VentanaPrincipal
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 532);
            this.Controls.Add(this.OpcionesgroupBox);
            this.Controls.Add(this.NumerogroupBox);
            this.Controls.Add(this.VentagroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.Text = "Ventas de Loterias";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.VentagroupBox.ResumeLayout(false);
            this.VentagroupBox.PerformLayout();
            this.NumerogroupBox.ResumeLayout(false);
            this.NumerogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).EndInit();
            this.OpcionesgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox VentagroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox NumerogroupBox;
        private System.Windows.Forms.Label UsuarioSistema;
        public System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox NumerotextBox;
        public System.Windows.Forms.TextBox MontotextBox;
        public System.Windows.Forms.Button GuardarButton;
        public System.Windows.Forms.Button AnularButton;
        public System.Windows.Forms.Button Cancelarbutton;
        public System.Windows.Forms.Button ReimprimirButton;
        private System.Windows.Forms.Button SalirButton;
        public System.Windows.Forms.Button UsuarioButton;
        public System.Windows.Forms.Button ReporteButton;
        public System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.GroupBox OpcionesgroupBox;
        private System.Windows.Forms.Label Hora;
        public System.Windows.Forms.Button Loteriabutton;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox NombreLoteriatextBox;
        public System.Windows.Forms.TextBox IdLoteriatextBox;
        private System.Windows.Forms.DataGridView DatosdataGridView;
    }
}