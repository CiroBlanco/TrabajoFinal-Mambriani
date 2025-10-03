namespace TrabajoFinal_Mambriani
{
    partial class FrmMesero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMesero));
            LblMesero = new Label();
            pictureBox1 = new PictureBox();
            DgvMeseros = new DataGridView();
            Id_Mesero = new DataGridViewTextBoxColumn();
            Nombre_Completo = new DataGridViewTextBoxColumn();
            Dni = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Fecha_Nacimiento = new DataGridViewTextBoxColumn();
            Horario_Inicio = new DataGridViewTextBoxColumn();
            Horario_Fin = new DataGridViewTextBoxColumn();
            Id_Sector = new DataGridViewTextBoxColumn();
            BtnAgregarMeseros = new Button();
            BtnEditarMeseros = new Button();
            BtnEliminarMeseros = new Button();
            BtnVolverMeseros = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvMeseros).BeginInit();
            SuspendLayout();
            // 
            // LblMesero
            // 
            LblMesero.AutoSize = true;
            LblMesero.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMesero.Location = new Point(329, -2);
            LblMesero.Name = "LblMesero";
            LblMesero.Size = new Size(140, 43);
            LblMesero.TabIndex = 0;
            LblMesero.Text = "MESEROS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 234);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 73);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // DgvMeseros
            // 
            DgvMeseros.AllowUserToAddRows = false;
            DgvMeseros.AllowUserToDeleteRows = false;
            DgvMeseros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMeseros.Columns.AddRange(new DataGridViewColumn[] { Id_Mesero, Nombre_Completo, Dni, Telefono, Fecha_Nacimiento, Horario_Inicio, Horario_Fin, Id_Sector });
            DgvMeseros.Location = new Point(34, 34);
            DgvMeseros.Name = "DgvMeseros";
            DgvMeseros.ReadOnly = true;
            DgvMeseros.Size = new Size(743, 150);
            DgvMeseros.TabIndex = 2;
            // 
            // Id_Mesero
            // 
            Id_Mesero.HeaderText = "Id_Mesero";
            Id_Mesero.Name = "Id_Mesero";
            Id_Mesero.ReadOnly = true;
            Id_Mesero.Visible = false;
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
            Telefono.HeaderText = "Teléfono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Fecha_Nacimiento
            // 
            Fecha_Nacimiento.HeaderText = "Fecha de Nacimiento";
            Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            Fecha_Nacimiento.ReadOnly = true;
            // 
            // Horario_Inicio
            // 
            Horario_Inicio.HeaderText = "Horario Entrada";
            Horario_Inicio.Name = "Horario_Inicio";
            Horario_Inicio.ReadOnly = true;
            // 
            // Horario_Fin
            // 
            Horario_Fin.HeaderText = "Horario Salida";
            Horario_Fin.Name = "Horario_Fin";
            Horario_Fin.ReadOnly = true;
            // 
            // Id_Sector
            // 
            Id_Sector.HeaderText = "Sector";
            Id_Sector.Name = "Id_Sector";
            Id_Sector.ReadOnly = true;
            // 
            // BtnAgregarMeseros
            // 
            BtnAgregarMeseros.Location = new Point(34, 190);
            BtnAgregarMeseros.Name = "BtnAgregarMeseros";
            BtnAgregarMeseros.Size = new Size(75, 23);
            BtnAgregarMeseros.TabIndex = 3;
            BtnAgregarMeseros.Text = "Agregar";
            BtnAgregarMeseros.UseVisualStyleBackColor = true;
            // 
            // BtnEditarMeseros
            // 
            BtnEditarMeseros.Location = new Point(115, 190);
            BtnEditarMeseros.Name = "BtnEditarMeseros";
            BtnEditarMeseros.Size = new Size(75, 23);
            BtnEditarMeseros.TabIndex = 4;
            BtnEditarMeseros.Text = "Editar";
            BtnEditarMeseros.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarMeseros
            // 
            BtnEliminarMeseros.Location = new Point(196, 190);
            BtnEliminarMeseros.Name = "BtnEliminarMeseros";
            BtnEliminarMeseros.Size = new Size(75, 23);
            BtnEliminarMeseros.TabIndex = 5;
            BtnEliminarMeseros.Text = "Eliminar";
            BtnEliminarMeseros.UseVisualStyleBackColor = true;
            // 
            // BtnVolverMeseros
            // 
            BtnVolverMeseros.Location = new Point(344, 313);
            BtnVolverMeseros.Name = "BtnVolverMeseros";
            BtnVolverMeseros.Size = new Size(75, 23);
            BtnVolverMeseros.TabIndex = 6;
            BtnVolverMeseros.Text = "Volver";
            BtnVolverMeseros.UseVisualStyleBackColor = true;
            BtnVolverMeseros.Click += BtnVolverMeseros_Click;
            // 
            // FrmMesero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnVolverMeseros);
            Controls.Add(BtnEliminarMeseros);
            Controls.Add(BtnEditarMeseros);
            Controls.Add(BtnAgregarMeseros);
            Controls.Add(DgvMeseros);
            Controls.Add(pictureBox1);
            Controls.Add(LblMesero);
            Name = "FrmMesero";
            Text = "FrmMesero";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvMeseros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblMesero;
        private PictureBox pictureBox1;
        private DataGridView DgvMeseros;
        private DataGridViewTextBoxColumn Id_Mesero;
        private DataGridViewTextBoxColumn Nombre_Completo;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Fecha_Nacimiento;
        private DataGridViewTextBoxColumn Horario_Inicio;
        private DataGridViewTextBoxColumn Horario_Fin;
        private DataGridViewTextBoxColumn Id_Sector;
        private Button BtnAgregarMeseros;
        private Button BtnEditarMeseros;
        private Button BtnEliminarMeseros;
        private Button BtnVolverMeseros;
    }
}