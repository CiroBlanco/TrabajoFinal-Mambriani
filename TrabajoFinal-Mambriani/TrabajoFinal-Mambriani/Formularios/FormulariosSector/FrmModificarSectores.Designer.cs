namespace TrabajoFinal_Mambriani
{
    partial class FrmModificarSectores
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
            TxtNombreSector = new TextBox();
            LblNombreSector = new Label();
            BtnAgregarSector = new Button();
            BtnEditarSector = new Button();
            BtnCancelarSector = new Button();
            SuspendLayout();
            // 
            // TxtNombreSector
            // 
            TxtNombreSector.Location = new Point(12, 34);
            TxtNombreSector.Name = "TxtNombreSector";
            TxtNombreSector.Size = new Size(100, 23);
            TxtNombreSector.TabIndex = 0;
            // 
            // LblNombreSector
            // 
            LblNombreSector.AutoSize = true;
            LblNombreSector.Location = new Point(12, 16);
            LblNombreSector.Name = "LblNombreSector";
            LblNombreSector.Size = new Size(54, 15);
            LblNombreSector.TabIndex = 1;
            LblNombreSector.Text = "Nombre:";
            // 
            // BtnAgregarSector
            // 
            BtnAgregarSector.Location = new Point(12, 80);
            BtnAgregarSector.Name = "BtnAgregarSector";
            BtnAgregarSector.Size = new Size(75, 23);
            BtnAgregarSector.TabIndex = 2;
            BtnAgregarSector.Text = "Agregar";
            BtnAgregarSector.UseVisualStyleBackColor = true;
            BtnAgregarSector.Click += BtnAgregarSector_Click;
            // 
            // BtnEditarSector
            // 
            BtnEditarSector.Location = new Point(12, 80);
            BtnEditarSector.Name = "BtnEditarSector";
            BtnEditarSector.Size = new Size(75, 23);
            BtnEditarSector.TabIndex = 3;
            BtnEditarSector.Text = "Editar";
            BtnEditarSector.UseVisualStyleBackColor = true;
            BtnEditarSector.Click += BtnEditarSector_Click;
            // 
            // BtnCancelarSector
            // 
            BtnCancelarSector.Location = new Point(118, 80);
            BtnCancelarSector.Name = "BtnCancelarSector";
            BtnCancelarSector.Size = new Size(75, 23);
            BtnCancelarSector.TabIndex = 4;
            BtnCancelarSector.Text = "Cancelar";
            BtnCancelarSector.UseVisualStyleBackColor = true;
            BtnCancelarSector.Click += BtnCancelarSector_Click;
            // 
            // FrmModificarSectores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(205, 148);
            Controls.Add(BtnCancelarSector);
            Controls.Add(BtnEditarSector);
            Controls.Add(BtnAgregarSector);
            Controls.Add(LblNombreSector);
            Controls.Add(TxtNombreSector);
            Name = "FrmModificarSectores";
            Text = "FrmModificarSectores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNombreSector;
        private Label LblNombreSector;
        private Button BtnAgregarSector;
        private Button BtnEditarSector;
        private Button BtnCancelarSector;
    }
}