namespace TrabajoFinal_Mambriani
{
    partial class FrmBebidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBebidas));
            DgvBebidas = new DataGridView();
            Id_Bebida = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Alcoholica = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            BtnAgregarBebida = new Button();
            BtnEditarBebida = new Button();
            BtnEliminarBebida = new Button();
            LblBebidas = new Label();
            pictureBox1 = new PictureBox();
            BtnVolverBebidas = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvBebidas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DgvBebidas
            // 
            DgvBebidas.AllowUserToAddRows = false;
            DgvBebidas.AllowUserToDeleteRows = false;
            DgvBebidas.BackgroundColor = Color.Cyan;
            DgvBebidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBebidas.Columns.AddRange(new DataGridViewColumn[] { Id_Bebida, Nombre, Descripcion, Alcoholica, Precio });
            DgvBebidas.Location = new Point(182, 89);
            DgvBebidas.Name = "DgvBebidas";
            DgvBebidas.ReadOnly = true;
            DgvBebidas.Size = new Size(443, 150);
            DgvBebidas.TabIndex = 0;
            // 
            // Id_Bebida
            // 
            Id_Bebida.HeaderText = "Id_Bebida";
            Id_Bebida.Name = "Id_Bebida";
            Id_Bebida.ReadOnly = true;
            Id_Bebida.Visible = false;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Alcoholica
            // 
            Alcoholica.HeaderText = "Alcoholica";
            Alcoholica.Name = "Alcoholica";
            Alcoholica.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // BtnAgregarBebida
            // 
            BtnAgregarBebida.Location = new Point(182, 245);
            BtnAgregarBebida.Name = "BtnAgregarBebida";
            BtnAgregarBebida.Size = new Size(75, 23);
            BtnAgregarBebida.TabIndex = 1;
            BtnAgregarBebida.Text = "Agregar";
            BtnAgregarBebida.UseVisualStyleBackColor = true;
            BtnAgregarBebida.Click += BtnAgregarBebida_Click;
            // 
            // BtnEditarBebida
            // 
            BtnEditarBebida.Location = new Point(275, 245);
            BtnEditarBebida.Name = "BtnEditarBebida";
            BtnEditarBebida.Size = new Size(75, 23);
            BtnEditarBebida.TabIndex = 2;
            BtnEditarBebida.Text = "Editar";
            BtnEditarBebida.UseVisualStyleBackColor = true;
            BtnEditarBebida.Click += BtnEditarBebida_Click;
            // 
            // BtnEliminarBebida
            // 
            BtnEliminarBebida.Location = new Point(366, 245);
            BtnEliminarBebida.Name = "BtnEliminarBebida";
            BtnEliminarBebida.Size = new Size(75, 23);
            BtnEliminarBebida.TabIndex = 3;
            BtnEliminarBebida.Text = "Eliminar";
            BtnEliminarBebida.UseVisualStyleBackColor = true;
            BtnEliminarBebida.Click += BtnEliminarBebida_Click;
            // 
            // LblBebidas
            // 
            LblBebidas.AutoSize = true;
            LblBebidas.BackColor = Color.SlateGray;
            LblBebidas.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            LblBebidas.ForeColor = SystemColors.ButtonFace;
            LblBebidas.Location = new Point(313, 36);
            LblBebidas.Name = "LblBebidas";
            LblBebidas.Size = new Size(141, 38);
            LblBebidas.TabIndex = 4;
            LblBebidas.Text = "BEBIDAS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-2, 310);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 76);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // BtnVolverBebidas
            // 
            BtnVolverBebidas.Location = new Point(348, 392);
            BtnVolverBebidas.Name = "BtnVolverBebidas";
            BtnVolverBebidas.Size = new Size(75, 23);
            BtnVolverBebidas.TabIndex = 6;
            BtnVolverBebidas.Text = "Volver";
            BtnVolverBebidas.UseVisualStyleBackColor = true;
            BtnVolverBebidas.Click += BtnVolverBebidas_Click;
            // 
            // FrmBebidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnVolverBebidas);
            Controls.Add(pictureBox1);
            Controls.Add(LblBebidas);
            Controls.Add(BtnEliminarBebida);
            Controls.Add(BtnEditarBebida);
            Controls.Add(BtnAgregarBebida);
            Controls.Add(DgvBebidas);
            Name = "FrmBebidas";
            Text = "FrmBebidas";
            ((System.ComponentModel.ISupportInitialize)DgvBebidas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvBebidas;
        private Button BtnAgregarBebida;
        private Button BtnEditarBebida;
        private Button BtnEliminarBebida;
        private Label LblBebidas;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Id_Bebida;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Alcoholica;
        private DataGridViewTextBoxColumn Precio;
        private Button BtnVolverBebidas;
    }
}