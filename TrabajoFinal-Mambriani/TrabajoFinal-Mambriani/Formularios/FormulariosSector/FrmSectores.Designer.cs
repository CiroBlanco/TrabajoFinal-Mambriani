namespace TrabajoFinal_Mambriani
{
    partial class FrmSectores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSectores));
            DgvSectores = new DataGridView();
            Id_Sector = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            BtnAgregarSectores = new Button();
            BtnEditarSectores = new Button();
            BtnEliminarSectores = new Button();
            BtnVolverSector = new Button();
            LblSectores = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvSectores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DgvSectores
            // 
            DgvSectores.AllowUserToAddRows = false;
            DgvSectores.AllowUserToDeleteRows = false;
            DgvSectores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvSectores.Columns.AddRange(new DataGridViewColumn[] { Id_Sector, Nombre });
            DgvSectores.Location = new Point(304, 64);
            DgvSectores.Name = "DgvSectores";
            DgvSectores.ReadOnly = true;
            DgvSectores.Size = new Size(143, 150);
            DgvSectores.TabIndex = 0;
            // 
            // Id_Sector
            // 
            Id_Sector.HeaderText = "Id_Sector";
            Id_Sector.Name = "Id_Sector";
            Id_Sector.ReadOnly = true;
            Id_Sector.Visible = false;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-2, 290);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(806, 74);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnAgregarSectores
            // 
            BtnAgregarSectores.Location = new Point(207, 224);
            BtnAgregarSectores.Name = "BtnAgregarSectores";
            BtnAgregarSectores.Size = new Size(75, 23);
            BtnAgregarSectores.TabIndex = 2;
            BtnAgregarSectores.Text = "Agregar";
            BtnAgregarSectores.UseVisualStyleBackColor = true;
            BtnAgregarSectores.Click += BtnAgregarSector_Click;
            // 
            // BtnEditarSectores
            // 
            BtnEditarSectores.Location = new Point(339, 224);
            BtnEditarSectores.Name = "BtnEditarSectores";
            BtnEditarSectores.Size = new Size(75, 23);
            BtnEditarSectores.TabIndex = 3;
            BtnEditarSectores.Text = "Editar";
            BtnEditarSectores.UseVisualStyleBackColor = true;
            BtnEditarSectores.Click += BtnEditarSectores_Click;
            // 
            // BtnEliminarSectores
            // 
            BtnEliminarSectores.Location = new Point(477, 224);
            BtnEliminarSectores.Name = "BtnEliminarSectores";
            BtnEliminarSectores.Size = new Size(75, 23);
            BtnEliminarSectores.TabIndex = 4;
            BtnEliminarSectores.Text = "Eliminar";
            BtnEliminarSectores.UseVisualStyleBackColor = true;
            BtnEliminarSectores.Click += BtnEliminarSectores_Click;
            // 
            // BtnVolverSector
            // 
            BtnVolverSector.Location = new Point(339, 370);
            BtnVolverSector.Name = "BtnVolverSector";
            BtnVolverSector.Size = new Size(75, 23);
            BtnVolverSector.TabIndex = 5;
            BtnVolverSector.Text = "Volver ";
            BtnVolverSector.UseVisualStyleBackColor = true;
            BtnVolverSector.Click += BtnVolverSector_Click;
            // 
            // LblSectores
            // 
            LblSectores.AutoSize = true;
            LblSectores.Font = new Font("MV Boli", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            LblSectores.Location = new Point(304, 9);
            LblSectores.Name = "LblSectores";
            LblSectores.Size = new Size(160, 34);
            LblSectores.TabIndex = 6;
            LblSectores.Text = "SECTORES";
            // 
            // FrmSectores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(LblSectores);
            Controls.Add(BtnVolverSector);
            Controls.Add(BtnEliminarSectores);
            Controls.Add(BtnEditarSectores);
            Controls.Add(BtnAgregarSectores);
            Controls.Add(pictureBox1);
            Controls.Add(DgvSectores);
            Name = "FrmSectores";
            Text = "FrmSector";
            ((System.ComponentModel.ISupportInitialize)DgvSectores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvSectores;
        private DataGridViewTextBoxColumn Id_Sector;
        private DataGridViewTextBoxColumn Nombre;
        private PictureBox pictureBox1;
        private Button BtnAgregarSectores;
        private Button BtnEditarSectores;
        private Button BtnEliminarSectores;
        private Button BtnVolverSector;
        private Label LblSectores;
    }
}