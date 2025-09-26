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
            DgvMesas = new DataGridView();
            BtnAgregar = new Button();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            Id_Mesa = new DataGridViewTextBoxColumn();
            Cantidad_Personas = new DataGridViewTextBoxColumn();
            Libre = new DataGridViewTextBoxColumn();
            Id_Sector = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvMesas).BeginInit();
            SuspendLayout();
            // 
            // DgvMesas
            // 
            DgvMesas.AllowUserToAddRows = false;
            DgvMesas.AllowUserToDeleteRows = false;
            DgvMesas.BackgroundColor = Color.FromArgb(255, 255, 128);
            DgvMesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMesas.Columns.AddRange(new DataGridViewColumn[] { Id_Mesa, Cantidad_Personas, Libre, Id_Sector });
            DgvMesas.Location = new Point(210, 52);
            DgvMesas.Name = "DgvMesas";
            DgvMesas.ReadOnly = true;
            DgvMesas.Size = new Size(345, 150);
            DgvMesas.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Silver;
            BtnAgregar.Location = new Point(210, 268);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 1;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.Silver;
            BtnEditar.Location = new Point(334, 268);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(75, 23);
            BtnEditar.TabIndex = 2;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.Silver;
            BtnEliminar.Location = new Point(460, 268);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
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
            // FrmMesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnAgregar);
            Controls.Add(DgvMesas);
            Name = "FrmMesas";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DgvMesas).EndInit();
            ResumeLayout(false);
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
    }
}
