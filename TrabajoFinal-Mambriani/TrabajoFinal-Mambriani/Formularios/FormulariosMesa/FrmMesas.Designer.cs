namespace TrabajoFinal_Mambriani
{
    partial class FrmMesas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMesas));
            DgvMesas = new DataGridView();
            Id_Mesa = new DataGridViewTextBoxColumn();
            Cantidad_Personas = new DataGridViewTextBoxColumn();
            Libre = new DataGridViewTextBoxColumn();
            Id_Sector = new DataGridViewTextBoxColumn();
            BtnAgregar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            LblTituloMesas = new Label();
            pictureBox1 = new PictureBox();
            BtnVolverMesas = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvMesas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DgvMesas
            // 
            DgvMesas.AllowUserToAddRows = false;
            DgvMesas.AllowUserToDeleteRows = false;
            DgvMesas.BackgroundColor = Color.FromArgb(255, 255, 128);
            DgvMesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMesas.Columns.AddRange(new DataGridViewColumn[] { Id_Mesa, Cantidad_Personas, Libre, Id_Sector });
            DgvMesas.Location = new Point(208, 72);
            DgvMesas.Name = "DgvMesas";
            DgvMesas.ReadOnly = true;
            DgvMesas.Size = new Size(343, 150);
            DgvMesas.TabIndex = 0;
            // 
            // Id_Mesa
            // 
            Id_Mesa.HeaderText = "Id_Mesa";
            Id_Mesa.Name = "Id_Mesa";
            Id_Mesa.ReadOnly = true;
            Id_Mesa.Visible = false;
            // 
            // Cantidad_Personas
            // 
            Cantidad_Personas.HeaderText = "Cantidad de Personas";
            Cantidad_Personas.Name = "Cantidad_Personas";
            Cantidad_Personas.ReadOnly = true;
            // 
            // Libre
            // 
            Libre.HeaderText = "Libre";
            Libre.Name = "Libre";
            Libre.ReadOnly = true;
            // 
            // Id_Sector
            // 
            Id_Sector.HeaderText = "Sector";
            Id_Sector.Name = "Id_Sector";
            Id_Sector.ReadOnly = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Silver;
            BtnAgregar.Location = new Point(208, 228);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.Silver;
            BtnEditar.Location = new Point(289, 228);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(75, 23);
            BtnEditar.TabIndex = 2;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.Silver;
            BtnEliminar.Location = new Point(370, 228);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // LblTituloMesas
            // 
            LblTituloMesas.AutoSize = true;
            LblTituloMesas.BackColor = Color.Transparent;
            LblTituloMesas.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            LblTituloMesas.ForeColor = SystemColors.Control;
            LblTituloMesas.Location = new Point(320, 22);
            LblTituloMesas.Name = "LblTituloMesas";
            LblTituloMesas.Size = new Size(116, 38);
            LblTituloMesas.TabIndex = 4;
            LblTituloMesas.Text = "MESAS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-1, 292);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 74);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // BtnVolverMesas
            // 
            BtnVolverMesas.BackColor = Color.Silver;
            BtnVolverMesas.Location = new Point(360, 372);
            BtnVolverMesas.Name = "BtnVolverMesas";
            BtnVolverMesas.Size = new Size(95, 23);
            BtnVolverMesas.TabIndex = 6;
            BtnVolverMesas.Text = "Volver Inicio";
            BtnVolverMesas.UseVisualStyleBackColor = false;
            BtnVolverMesas.Click += BtnVolverMesas_Click;
            // 
            // FrmMesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnVolverMesas);
            Controls.Add(pictureBox1);
            Controls.Add(LblTituloMesas);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnAgregar);
            Controls.Add(DgvMesas);
            Name = "FrmMesas";
            Text = "FormMesas";
            ((System.ComponentModel.ISupportInitialize)DgvMesas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvMesas;
        private Button BtnAgregar;
        private Button BtnEditar;
        private Button BtnEliminar;
        private DataGridViewTextBoxColumn Id_Mesa;
        private DataGridViewTextBoxColumn Cantidad_Personas;
        private DataGridViewTextBoxColumn Libre;
        private DataGridViewTextBoxColumn Id_Sector;
        private Label LblTituloMesas;
        private PictureBox pictureBox1;
        private Button BtnVolverMesas;
    }
}
