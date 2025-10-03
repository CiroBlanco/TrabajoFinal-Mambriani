namespace TrabajoFinal_Mambriani
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            PcbLogo = new PictureBox();
            BtnMesas = new Button();
            BtnSectores = new Button();
            BtnPlatos = new Button();
            BtnMeseros = new Button();
            BtnBebidas = new Button();
            BtnChefs = new Button();
            ((System.ComponentModel.ISupportInitialize)PcbLogo).BeginInit();
            SuspendLayout();
            // 
            // PcbLogo
            // 
            PcbLogo.AccessibleRole = AccessibleRole.None;
            PcbLogo.Anchor = AnchorStyles.Top;
            PcbLogo.BackgroundImage = (Image)resources.GetObject("PcbLogo.BackgroundImage");
            PcbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            PcbLogo.Location = new Point(142, 22);
            PcbLogo.Name = "PcbLogo";
            PcbLogo.Size = new Size(920, 214);
            PcbLogo.TabIndex = 0;
            PcbLogo.TabStop = false;
            // 
            // BtnMesas
            // 
            BtnMesas.BackColor = Color.Orange;
            BtnMesas.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMesas.ForeColor = Color.Sienna;
            BtnMesas.Location = new Point(157, 252);
            BtnMesas.Name = "BtnMesas";
            BtnMesas.Size = new Size(186, 41);
            BtnMesas.TabIndex = 1;
            BtnMesas.Text = "Mesas";
            BtnMesas.UseVisualStyleBackColor = false;
            BtnMesas.Click += BtnMesas_Click;
            // 
            // BtnSectores
            // 
            BtnSectores.BackColor = Color.Orange;
            BtnSectores.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSectores.ForeColor = Color.Sienna;
            BtnSectores.Location = new Point(860, 322);
            BtnSectores.Name = "BtnSectores";
            BtnSectores.Size = new Size(186, 41);
            BtnSectores.TabIndex = 2;
            BtnSectores.Text = "Sectores";
            BtnSectores.UseVisualStyleBackColor = false;
            BtnSectores.Click += BtnSectores_Click;
            // 
            // BtnPlatos
            // 
            BtnPlatos.BackColor = Color.Orange;
            BtnPlatos.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPlatos.ForeColor = Color.Sienna;
            BtnPlatos.Location = new Point(523, 322);
            BtnPlatos.Name = "BtnPlatos";
            BtnPlatos.Size = new Size(186, 41);
            BtnPlatos.TabIndex = 3;
            BtnPlatos.Text = "Platos";
            BtnPlatos.UseVisualStyleBackColor = false;
            BtnPlatos.Click += BtnPlatos_Click;
            // 
            // BtnMeseros
            // 
            BtnMeseros.BackColor = Color.Orange;
            BtnMeseros.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMeseros.ForeColor = Color.Sienna;
            BtnMeseros.Location = new Point(157, 322);
            BtnMeseros.Name = "BtnMeseros";
            BtnMeseros.Size = new Size(186, 41);
            BtnMeseros.TabIndex = 4;
            BtnMeseros.Text = "Meseros";
            BtnMeseros.UseVisualStyleBackColor = false;
            BtnMeseros.Click += BtnMeseros_Click;
            // 
            // BtnBebidas
            // 
            BtnBebidas.BackColor = Color.Orange;
            BtnBebidas.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBebidas.ForeColor = Color.Sienna;
            BtnBebidas.Location = new Point(523, 252);
            BtnBebidas.Name = "BtnBebidas";
            BtnBebidas.Size = new Size(186, 41);
            BtnBebidas.TabIndex = 5;
            BtnBebidas.Text = "Bebidas";
            BtnBebidas.UseVisualStyleBackColor = false;
            BtnBebidas.Click += BtnBebidas_Click;
            // 
            // BtnChefs
            // 
            BtnChefs.BackColor = Color.Orange;
            BtnChefs.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnChefs.ForeColor = Color.Sienna;
            BtnChefs.Location = new Point(860, 252);
            BtnChefs.Name = "BtnChefs";
            BtnChefs.Size = new Size(186, 41);
            BtnChefs.TabIndex = 6;
            BtnChefs.Text = "Chefs";
            BtnChefs.UseVisualStyleBackColor = false;
            BtnChefs.Click += BtnChefs_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(1218, 450);
            Controls.Add(BtnChefs);
            Controls.Add(BtnBebidas);
            Controls.Add(BtnMeseros);
            Controls.Add(BtnPlatos);
            Controls.Add(BtnSectores);
            Controls.Add(BtnMesas);
            Controls.Add(PcbLogo);
            Name = "FrmInicio";
            Text = "Mambriani's Restaurant";
            ((System.ComponentModel.ISupportInitialize)PcbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PcbLogo;
        private Button BtnMesas;
        private Button BtnSectores;
        private Button BtnPlatos;
        private Button BtnMeseros;
        private Button BtnBebidas;
        private Button BtnChefs;
    }
}