namespace SistemasDeBancas.Consulta
{
    partial class ConsultaUsuarios
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
            this.CamposComboBox = new System.Windows.Forms.ComboBox();
            this.FiltroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.SalirButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CamposComboBox
            // 
            this.CamposComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CamposComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamposComboBox.FormattingEnabled = true;
            this.CamposComboBox.Items.AddRange(new object[] {
            "UsuarioID",
            "Nombre"});
            this.CamposComboBox.Location = new System.Drawing.Point(71, 29);
            this.CamposComboBox.Name = "CamposComboBox";
            this.CamposComboBox.Size = new System.Drawing.Size(121, 28);
            this.CamposComboBox.TabIndex = 64;
            this.CamposComboBox.SelectedIndexChanged += new System.EventHandler(this.CamposComboBox_SelectedIndexChanged);
            // 
            // FiltroTextBox
            // 
            this.FiltroTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltroTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FiltroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroTextBox.Location = new System.Drawing.Point(211, 31);
            this.FiltroTextBox.Name = "FiltroTextBox";
            this.FiltroTextBox.Size = new System.Drawing.Size(142, 26);
            this.FiltroTextBox.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Filtrar ";
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Location = new System.Drawing.Point(12, 63);
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.Size = new System.Drawing.Size(482, 215);
            this.DatosDataGridView.TabIndex = 60;
            this.DatosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosDataGridView_CellContentClick);
            // 
            // SalirButton
            // 
            this.SalirButton.BackgroundImage = global::SistemasDeBancas.Properties.Resources.Salir;
            this.SalirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SalirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SalirButton.Location = new System.Drawing.Point(378, 284);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(116, 52);
            this.SalirButton.TabIndex = 68;
            this.SalirButton.Text = "Salir";
            this.SalirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackgroundImage = global::SistemasDeBancas.Properties.Resources.Anular;
            this.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EliminarButton.Enabled = false;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EliminarButton.Location = new System.Drawing.Point(256, 284);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(116, 52);
            this.EliminarButton.TabIndex = 67;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // EditarButton
            // 
            this.EditarButton.BackgroundImage = global::SistemasDeBancas.Properties.Resources.floppy_drive_3_12_icon;
            this.EditarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditarButton.Enabled = false;
            this.EditarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EditarButton.Location = new System.Drawing.Point(134, 284);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(116, 52);
            this.EditarButton.TabIndex = 66;
            this.EditarButton.Text = "Editar";
            this.EditarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditarButton.UseVisualStyleBackColor = true;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackgroundImage = global::SistemasDeBancas.Properties.Resources.New;
            this.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.NuevoButton.Location = new System.Drawing.Point(12, 284);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(116, 52);
            this.NuevoButton.TabIndex = 65;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Buscarbutton.Image = global::SistemasDeBancas.Properties.Resources.Search_icon;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(360, 6);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(135, 52);
            this.Buscarbutton.TabIndex = 61;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // ConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 358);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.EditarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.CamposComboBox);
            this.Controls.Add(this.FiltroTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.DatosDataGridView);
            this.Name = "ConsultaUsuarios";
            this.Text = "ConsultaUsuarios";
            this.Load += new System.EventHandler(this.ConsultaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CamposComboBox;
        private System.Windows.Forms.TextBox FiltroTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button SalirButton;
        public System.Windows.Forms.DataGridView DatosDataGridView;
    }
}