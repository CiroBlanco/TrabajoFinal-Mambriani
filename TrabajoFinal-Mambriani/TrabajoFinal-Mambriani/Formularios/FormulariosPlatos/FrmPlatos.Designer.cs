namespace TrabajoFinal_Mambriani
{
    partial class FrmPlatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlatos));
            BtnAgregarPlato = new Button();
            BtnEditarPlato = new Button();
            BtnEliminarPlato = new Button();
            DgvPlatos = new DataGridView();
            Id_Plato = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            BtnVolverPlato = new Button();
            LblPlatos = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DgvPlatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnAgregarPlato
            // 
            BtnAgregarPlato.BackColor = Color.Silver;
            BtnAgregarPlato.Location = new Point(59, 347);
            BtnAgregarPlato.Margin = new Padding(4);
            BtnAgregarPlato.Name = "BtnAgregarPlato";
            BtnAgregarPlato.Size = new Size(107, 30);
            BtnAgregarPlato.TabIndex = 0;
            BtnAgregarPlato.Text = "Agregar";
            BtnAgregarPlato.UseVisualStyleBackColor = false;
            BtnAgregarPlato.Click += BtnAgregarPlato_Click;
            // 
            // BtnEditarPlato
            // 
            BtnEditarPlato.BackColor = Color.Silver;
            BtnEditarPlato.Location = new Point(259, 347);
            BtnEditarPlato.Margin = new Padding(4);
            BtnEditarPlato.Name = "BtnEditarPlato";
            BtnEditarPlato.Size = new Size(107, 30);
            BtnEditarPlato.TabIndex = 1;
            BtnEditarPlato.Text = "Editar";
            BtnEditarPlato.UseVisualStyleBackColor = false;
            BtnEditarPlato.Click += BtnEditarPlato_Click;
            // 
            // BtnEliminarPlato
            // 
            BtnEliminarPlato.BackColor = Color.Silver;
            BtnEliminarPlato.Location = new Point(474, 347);
            BtnEliminarPlato.Margin = new Padding(4);
            BtnEliminarPlato.Name = "BtnEliminarPlato";
            BtnEliminarPlato.Size = new Size(107, 30);
            BtnEliminarPlato.TabIndex = 2;
            BtnEliminarPlato.Text = "Eliminar";
            BtnEliminarPlato.UseVisualStyleBackColor = false;
            BtnEliminarPlato.Click += BtnEliminarPlato_Click;
            // 
            // DgvPlatos
            // 
            DgvPlatos.AllowUserToAddRows = false;
            DgvPlatos.AllowUserToDeleteRows = false;
            DgvPlatos.BackgroundColor = Color.Gainsboro;
            DgvPlatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPlatos.Columns.AddRange(new DataGridViewColumn[] { Id_Plato, Nombre, Descripcion, Precio });
            DgvPlatos.Location = new Point(158, 125);
            DgvPlatos.Margin = new Padding(4);
            DgvPlatos.Name = "DgvPlatos";
            DgvPlatos.ReadOnly = true;
            DgvPlatos.Size = new Size(343, 200);
            DgvPlatos.TabIndex = 3;
            // 
            // Id_Plato
            // 
            Id_Plato.HeaderText = "Id_Plato";
            Id_Plato.Name = "Id_Plato";
            Id_Plato.ReadOnly = true;
            Id_Plato.Visible = false;
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
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // BtnVolverPlato
            // 
            BtnVolverPlato.BackColor = Color.Silver;
            BtnVolverPlato.Location = new Point(259, 528);
            BtnVolverPlato.Margin = new Padding(4);
            BtnVolverPlato.Name = "BtnVolverPlato";
            BtnVolverPlato.Size = new Size(107, 30);
            BtnVolverPlato.TabIndex = 4;
            BtnVolverPlato.Text = "Volver";
            BtnVolverPlato.UseVisualStyleBackColor = false;
            BtnVolverPlato.Click += BtnVolverPlato_Click;
            // 
            // LblPlatos
            // 
            LblPlatos.AutoSize = true;
            LblPlatos.Font = new Font("Century", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            LblPlatos.Location = new Point(259, 57);
            LblPlatos.Margin = new Padding(4, 0, 4, 0);
            LblPlatos.Name = "LblPlatos";
            LblPlatos.Size = new Size(133, 33);
            LblPlatos.TabIndex = 5;
            LblPlatos.Text = "PLATOS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 404);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(672, 76);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FrmPlatos
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(673, 600);
            Controls.Add(pictureBox1);
            Controls.Add(LblPlatos);
            Controls.Add(BtnVolverPlato);
            Controls.Add(DgvPlatos);
            Controls.Add(BtnEliminarPlato);
            Controls.Add(BtnEditarPlato);
            Controls.Add(BtnAgregarPlato);
            Font = new Font("MV Boli", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmPlatos";
            Text = "FrmPlatos";
            ((System.ComponentModel.ISupportInitialize)DgvPlatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAgregarPlato;
        private Button BtnEditarPlato;
        private Button BtnEliminarPlato;
        private DataGridView DgvPlatos;
        private DataGridViewTextBoxColumn Id_Plato;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private Button BtnVolverPlato;
        private Label LblPlatos;
        private PictureBox pictureBox1;
    }
}