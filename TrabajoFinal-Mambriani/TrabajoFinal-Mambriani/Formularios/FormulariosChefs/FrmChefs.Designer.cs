namespace TrabajoFinal_Mambriani
{
    partial class FrmChefs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChefs));
            DgvChefs = new DataGridView();
            BtnAgregarChefs = new Button();
            BtnEditarChefs = new Button();
            BtnEliminarChefs = new Button();
            BtnVolverChefs = new Button();
            LblChef = new Label();
            pictureBox1 = new PictureBox();
            Id_Chef = new DataGridViewTextBoxColumn();
            Nombre_Completo = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Fecha_Nacimiento = new DataGridViewTextBoxColumn();
            Horario_Inicio = new DataGridViewTextBoxColumn();
            Horario_Fin = new DataGridViewTextBoxColumn();
            Id_Sector = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvChefs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DgvChefs
            // 
            DgvChefs.AllowUserToAddRows = false;
            DgvChefs.AllowUserToDeleteRows = false;
            DgvChefs.BackgroundColor = Color.NavajoWhite;
            DgvChefs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvChefs.Columns.AddRange(new DataGridViewColumn[] { Id_Chef, Nombre_Completo, Dni, Telefono, Fecha_Nacimiento, Horario_Inicio, Horario_Fin, Id_Sector });
            DgvChefs.Location = new Point(24, 64);
            DgvChefs.Name = "DgvChefs";
            DgvChefs.ReadOnly = true;
            DgvChefs.Size = new Size(743, 150);
            DgvChefs.TabIndex = 0;
            // 
            // BtnAgregarChefs
            // 
            BtnAgregarChefs.BackColor = SystemColors.ActiveBorder;
            BtnAgregarChefs.Location = new Point(79, 220);
            BtnAgregarChefs.Name = "BtnAgregarChefs";
            BtnAgregarChefs.Size = new Size(75, 23);
            BtnAgregarChefs.TabIndex = 1;
            BtnAgregarChefs.Text = "Agregar";
            BtnAgregarChefs.UseVisualStyleBackColor = false;
            BtnAgregarChefs.Click += BtnAgregarChefs_Click;
            // 
            // BtnEditarChefs
            // 
            BtnEditarChefs.BackColor = SystemColors.ActiveBorder;
            BtnEditarChefs.Location = new Point(160, 220);
            BtnEditarChefs.Name = "BtnEditarChefs";
            BtnEditarChefs.Size = new Size(75, 23);
            BtnEditarChefs.TabIndex = 2;
            BtnEditarChefs.Text = "Editar";
            BtnEditarChefs.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarChefs
            // 
            BtnEliminarChefs.BackColor = SystemColors.ActiveBorder;
            BtnEliminarChefs.Location = new Point(241, 220);
            BtnEliminarChefs.Name = "BtnEliminarChefs";
            BtnEliminarChefs.Size = new Size(75, 23);
            BtnEliminarChefs.TabIndex = 3;
            BtnEliminarChefs.Text = "Eliminar";
            BtnEliminarChefs.UseVisualStyleBackColor = false;
            // 
            // BtnVolverChefs
            // 
            BtnVolverChefs.BackColor = SystemColors.ActiveBorder;
            BtnVolverChefs.Location = new Point(343, 370);
            BtnVolverChefs.Name = "BtnVolverChefs";
            BtnVolverChefs.Size = new Size(75, 23);
            BtnVolverChefs.TabIndex = 4;
            BtnVolverChefs.Text = "Volver";
            BtnVolverChefs.UseVisualStyleBackColor = false;
            BtnVolverChefs.Click += BtnVolverChefs_Click;
            // 
            // LblChef
            // 
            LblChef.AutoSize = true;
            LblChef.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            LblChef.Location = new Point(330, 25);
            LblChef.Name = "LblChef";
            LblChef.Size = new Size(101, 36);
            LblChef.TabIndex = 5;
            LblChef.Text = "CHEFS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 277);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 75);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Id_Chef
            // 
            Id_Chef.HeaderText = "Id_Chef";
            Id_Chef.Name = "Id_Chef";
            Id_Chef.ReadOnly = true;
            Id_Chef.Visible = false;
            // 
            // Nombre_Completo
            // 
            Nombre_Completo.HeaderText = "Nombre Completo";
            Nombre_Completo.Name = "Nombre_Completo";
            Nombre_Completo.ReadOnly = true;
            // 
            // Dni
            // 
            Dni.HeaderText = "DNI";
            Dni.Name = "Dni";
            Dni.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Fecha_Nacimiento
            // 
            Fecha_Nacimiento.HeaderText = "Fecha Nacimiento";
            Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            Fecha_Nacimiento.ReadOnly = true;
            // 
            // Horario_Inicio
            // 
            Horario_Inicio.HeaderText = "Horario_Inicio";
            Horario_Inicio.Name = "Horario_Inicio";
            Horario_Inicio.ReadOnly = true;
            // 
            // Horario_Fin
            // 
            Horario_Fin.HeaderText = "Horario_Fin";
            Horario_Fin.Name = "Horario_Fin";
            Horario_Fin.ReadOnly = true;
            // 
            // Id_Sector
            // 
            Id_Sector.HeaderText = "Sector";
            Id_Sector.Name = "Id_Sector";
            Id_Sector.ReadOnly = true;
            // 
            // FrmChefs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(LblChef);
            Controls.Add(BtnVolverChefs);
            Controls.Add(BtnEliminarChefs);
            Controls.Add(BtnEditarChefs);
            Controls.Add(BtnAgregarChefs);
            Controls.Add(DgvChefs);
            Name = "FrmChefs";
            Text = "FrmChefs";
            ((System.ComponentModel.ISupportInitialize)DgvChefs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvChefs;
        private Button BtnAgregarChefs;
        private Button BtnEditarChefs;
        private Button BtnEliminarChefs;
        private Button BtnVolverChefs;
        private Label LblChef;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Id_Chef;
        private DataGridViewTextBoxColumn Nombre_Completo;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Fecha_Nacimiento;
        private DataGridViewTextBoxColumn Horario_Inicio;
        private DataGridViewTextBoxColumn Horario_Fin;
        private DataGridViewTextBoxColumn Id_Sector;
    }
}