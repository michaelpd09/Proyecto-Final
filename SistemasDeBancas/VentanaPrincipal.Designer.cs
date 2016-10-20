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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroTicket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Monto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.TextBox();
            this.Pale = new System.Windows.Forms.ListView();
            this.Tripleta = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.AnularButton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.ReimprimirButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SalirButton = new System.Windows.Forms.Button();
            this.PerfilesButton = new System.Windows.Forms.Button();
            this.UsuarioButton = new System.Windows.Forms.Button();
            this.ReporteButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Quiniela = new System.Windows.Forms.ListView();
            this.TotalQuiniela = new System.Windows.Forms.TextBox();
            this.TotalPale = new System.Windows.Forms.TextBox();
            this.TotalTripleta = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket:";
            // 
            // NumeroTicket
            // 
            this.NumeroTicket.Location = new System.Drawing.Point(70, 15);
            this.NumeroTicket.Name = "NumeroTicket";
            this.NumeroTicket.ReadOnly = true;
            this.NumeroTicket.Size = new System.Drawing.Size(100, 20);
            this.NumeroTicket.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto";
            // 
            // Monto
            // 
            this.Monto.Location = new System.Drawing.Point(70, 50);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(100, 20);
            this.Monto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(176, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero";
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(240, 52);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(121, 20);
            this.Numero.TabIndex = 5;
            // 
            // Pale
            // 
            this.Pale.BackColor = System.Drawing.Color.White;
            this.Pale.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Pale.Location = new System.Drawing.Point(198, 128);
            this.Pale.Name = "Pale";
            this.Pale.Size = new System.Drawing.Size(174, 295);
            this.Pale.TabIndex = 7;
            this.Pale.UseCompatibleStateImageBehavior = false;
            // 
            // Tripleta
            // 
            this.Tripleta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Tripleta.Location = new System.Drawing.Point(378, 128);
            this.Tripleta.Name = "Tripleta";
            this.Tripleta.Size = new System.Drawing.Size(174, 295);
            this.Tripleta.TabIndex = 8;
            this.Tripleta.UseCompatibleStateImageBehavior = false;
            this.Tripleta.SelectedIndexChanged += new System.EventHandler(this.Tripleta_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(66, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quiniela";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(266, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(433, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tripleta";
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.Color.Transparent;
            this.GuardarButton.BackgroundImage = global::SistemasDeBancas.Properties.Resources.floppy_drive_3_12_icon;
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.Location = new System.Drawing.Point(632, 52);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(136, 48);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = false;
            // 
            // AnularButton
            // 
            this.AnularButton.BackColor = System.Drawing.Color.Transparent;
            this.AnularButton.BackgroundImage = global::SistemasDeBancas.Properties.Resources.Anular;
            this.AnularButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AnularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnularButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AnularButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AnularButton.Location = new System.Drawing.Point(632, 212);
            this.AnularButton.Name = "AnularButton";
            this.AnularButton.Size = new System.Drawing.Size(136, 48);
            this.AnularButton.TabIndex = 13;
            this.AnularButton.Text = "Anular";
            this.AnularButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AnularButton.UseVisualStyleBackColor = false;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.Color.Transparent;
            this.Nuevobutton.BackgroundImage = global::SistemasDeBancas.Properties.Resources.New;
            this.Nuevobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Nuevobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevobutton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.Location = new System.Drawing.Point(632, 106);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(136, 48);
            this.Nuevobutton.TabIndex = 14;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            // 
            // ReimprimirButton
            // 
            this.ReimprimirButton.BackColor = System.Drawing.Color.Transparent;
            this.ReimprimirButton.BackgroundImage = global::SistemasDeBancas.Properties.Resources.Reimprimir;
            this.ReimprimirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReimprimirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReimprimirButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ReimprimirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReimprimirButton.Location = new System.Drawing.Point(632, 159);
            this.ReimprimirButton.Name = "ReimprimirButton";
            this.ReimprimirButton.Size = new System.Drawing.Size(136, 48);
            this.ReimprimirButton.TabIndex = 15;
            this.ReimprimirButton.Text = "Reimprimir";
            this.ReimprimirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReimprimirButton.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(632, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // SalirButton
            // 
            this.SalirButton.BackColor = System.Drawing.Color.Transparent;
            this.SalirButton.BackgroundImage = global::SistemasDeBancas.Properties.Resources.Salir;
            this.SalirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SalirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SalirButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SalirButton.Location = new System.Drawing.Point(632, 424);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(136, 48);
            this.SalirButton.TabIndex = 17;
            this.SalirButton.Text = "Salir";
            this.SalirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SalirButton.UseVisualStyleBackColor = false;
            this.SalirButton.Click += new System.EventHandler(this.Salirbutton_Click);
            // 
            // PerfilesButton
            // 
            this.PerfilesButton.BackColor = System.Drawing.Color.Transparent;
            this.PerfilesButton.BackgroundImage = global::SistemasDeBancas.Properties.Resources.perfir;
            this.PerfilesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PerfilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerfilesButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PerfilesButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.PerfilesButton.Location = new System.Drawing.Point(632, 318);
            this.PerfilesButton.Name = "PerfilesButton";
            this.PerfilesButton.Size = new System.Drawing.Size(136, 48);
            this.PerfilesButton.TabIndex = 18;
            this.PerfilesButton.Text = "Perfiles";
            this.PerfilesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PerfilesButton.UseVisualStyleBackColor = false;
            // 
            // UsuarioButton
            // 
            this.UsuarioButton.BackColor = System.Drawing.Color.Transparent;
            this.UsuarioButton.BackgroundImage = global::SistemasDeBancas.Properties.Resources.Actions_user_group_new_icon;
            this.UsuarioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UsuarioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.UsuarioButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.UsuarioButton.Location = new System.Drawing.Point(632, 371);
            this.UsuarioButton.Name = "UsuarioButton";
            this.UsuarioButton.Size = new System.Drawing.Size(136, 48);
            this.UsuarioButton.TabIndex = 19;
            this.UsuarioButton.Text = "Usuarios";
            this.UsuarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UsuarioButton.UseVisualStyleBackColor = false;
            // 
            // ReporteButton
            // 
            this.ReporteButton.BackColor = System.Drawing.Color.Transparent;
            this.ReporteButton.BackgroundImage = global::SistemasDeBancas.Properties.Resources.Reporte;
            this.ReporteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReporteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ReporteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReporteButton.Location = new System.Drawing.Point(632, 265);
            this.ReporteButton.Name = "ReporteButton";
            this.ReporteButton.Size = new System.Drawing.Size(136, 48);
            this.ReporteButton.TabIndex = 20;
            this.ReporteButton.Text = "Reporte";
            this.ReporteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReporteButton.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(176, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Loteria";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // Quiniela
            // 
            this.Quiniela.BackColor = System.Drawing.Color.White;
            this.Quiniela.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Quiniela.Location = new System.Drawing.Point(18, 128);
            this.Quiniela.Name = "Quiniela";
            this.Quiniela.Size = new System.Drawing.Size(175, 295);
            this.Quiniela.TabIndex = 6;
            this.Quiniela.UseCompatibleStateImageBehavior = false;
            // 
            // TotalQuiniela
            // 
            this.TotalQuiniela.BackColor = System.Drawing.Color.DodgerBlue;
            this.TotalQuiniela.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalQuiniela.ForeColor = System.Drawing.Color.White;
            this.TotalQuiniela.Location = new System.Drawing.Point(18, 428);
            this.TotalQuiniela.Name = "TotalQuiniela";
            this.TotalQuiniela.Size = new System.Drawing.Size(175, 44);
            this.TotalQuiniela.TabIndex = 23;
            this.TotalQuiniela.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TotalPale
            // 
            this.TotalPale.BackColor = System.Drawing.Color.DodgerBlue;
            this.TotalPale.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPale.ForeColor = System.Drawing.Color.White;
            this.TotalPale.Location = new System.Drawing.Point(198, 428);
            this.TotalPale.Name = "TotalPale";
            this.TotalPale.Size = new System.Drawing.Size(174, 44);
            this.TotalPale.TabIndex = 24;
            // 
            // TotalTripleta
            // 
            this.TotalTripleta.BackColor = System.Drawing.Color.DodgerBlue;
            this.TotalTripleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTripleta.ForeColor = System.Drawing.Color.White;
            this.TotalTripleta.Location = new System.Drawing.Point(378, 428);
            this.TotalTripleta.Name = "TotalTripleta";
            this.TotalTripleta.Size = new System.Drawing.Size(174, 44);
            this.TotalTripleta.TabIndex = 25;
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.Color.White;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Total.Location = new System.Drawing.Point(378, 24);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(174, 44);
            this.Total.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(433, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Total";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 512);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.TotalTripleta);
            this.Controls.Add(this.TotalPale);
            this.Controls.Add(this.TotalQuiniela);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReporteButton);
            this.Controls.Add(this.UsuarioButton);
            this.Controls.Add(this.PerfilesButton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ReimprimirButton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.AnularButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tripleta);
            this.Controls.Add(this.Pale);
            this.Controls.Add(this.Quiniela);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumeroTicket);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.Text = "Ventas de Loterias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.ListView Pale;
        private System.Windows.Forms.ListView Tripleta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button AnularButton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button ReimprimirButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button PerfilesButton;
        private System.Windows.Forms.Button UsuarioButton;
        private System.Windows.Forms.Button ReporteButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView Quiniela;
        private System.Windows.Forms.TextBox TotalQuiniela;
        private System.Windows.Forms.TextBox TotalPale;
        private System.Windows.Forms.TextBox TotalTripleta;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label8;
    }
}