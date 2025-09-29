namespace TrabajoFinal_Mambriani
{
    partial class FrmModificarPlatos
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
            LblNombrePlato = new Label();
            LblDescripcionPlato = new Label();
            TxtNombrePlato = new TextBox();
            LblPrecioPlato = new Label();
            TxtPrecioPlato = new TextBox();
            BtnAgregarPlato = new Button();
            BtnCancelarPlato = new Button();
            BtnEditarPlato = new Button();
            TxtDescripcionPlato = new TextBox();
            SuspendLayout();
            // 
            // LblNombrePlato
            // 
            LblNombrePlato.AutoSize = true;
            LblNombrePlato.Location = new Point(12, 9);
            LblNombrePlato.Name = "LblNombrePlato";
            LblNombrePlato.Size = new Size(54, 15);
            LblNombrePlato.TabIndex = 0;
            LblNombrePlato.Text = "Nombre:";
            // 
            // LblDescripcionPlato
            // 
            LblDescripcionPlato.AutoSize = true;
            LblDescripcionPlato.Location = new Point(12, 92);
            LblDescripcionPlato.Name = "LblDescripcionPlato";
            LblDescripcionPlato.Size = new Size(69, 15);
            LblDescripcionPlato.TabIndex = 2;
            LblDescripcionPlato.Text = "Descripcion";
            // 
            // TxtNombrePlato
            // 
            TxtNombrePlato.Location = new Point(12, 28);
            TxtNombrePlato.Name = "TxtNombrePlato";
            TxtNombrePlato.Size = new Size(100, 23);
            TxtNombrePlato.TabIndex = 3;
            // 
            // LblPrecioPlato
            // 
            LblPrecioPlato.AutoSize = true;
            LblPrecioPlato.Location = new Point(12, 200);
            LblPrecioPlato.Name = "LblPrecioPlato";
            LblPrecioPlato.Size = new Size(40, 15);
            LblPrecioPlato.TabIndex = 4;
            LblPrecioPlato.Text = "Precio";
            // 
            // TxtPrecioPlato
            // 
            TxtPrecioPlato.Location = new Point(12, 218);
            TxtPrecioPlato.Name = "TxtPrecioPlato";
            TxtPrecioPlato.Size = new Size(100, 23);
            TxtPrecioPlato.TabIndex = 5;
            // 
            // BtnAgregarPlato
            // 
            BtnAgregarPlato.Location = new Point(12, 273);
            BtnAgregarPlato.Name = "BtnAgregarPlato";
            BtnAgregarPlato.Size = new Size(75, 23);
            BtnAgregarPlato.TabIndex = 6;
            BtnAgregarPlato.Text = "Agregar";
            BtnAgregarPlato.UseVisualStyleBackColor = true;
            BtnAgregarPlato.Click += BtnAgregarPlato_Click;
            // 
            // BtnCancelarPlato
            // 
            BtnCancelarPlato.Location = new Point(126, 273);
            BtnCancelarPlato.Name = "BtnCancelarPlato";
            BtnCancelarPlato.Size = new Size(75, 23);
            BtnCancelarPlato.TabIndex = 7;
            BtnCancelarPlato.Text = "Cancelar";
            BtnCancelarPlato.UseVisualStyleBackColor = true;
            BtnCancelarPlato.Click += BtnCancelarPlato_Click;
            // 
            // BtnEditarPlato
            // 
            BtnEditarPlato.Location = new Point(12, 273);
            BtnEditarPlato.Name = "BtnEditarPlato";
            BtnEditarPlato.Size = new Size(75, 23);
            BtnEditarPlato.TabIndex = 9;
            BtnEditarPlato.Text = "Editar";
            BtnEditarPlato.UseVisualStyleBackColor = true;
            BtnEditarPlato.Click += BtnEditarPlato_Click;
            // 
            // TxtDescripcionPlato
            // 
            TxtDescripcionPlato.Location = new Point(12, 110);
            TxtDescripcionPlato.Multiline = true;
            TxtDescripcionPlato.Name = "TxtDescripcionPlato";
            TxtDescripcionPlato.Size = new Size(256, 61);
            TxtDescripcionPlato.TabIndex = 10;
            // 
            // FrmModificarPlatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 313);
            Controls.Add(TxtDescripcionPlato);
            Controls.Add(BtnEditarPlato);
            Controls.Add(BtnCancelarPlato);
            Controls.Add(BtnAgregarPlato);
            Controls.Add(TxtPrecioPlato);
            Controls.Add(LblPrecioPlato);
            Controls.Add(TxtNombrePlato);
            Controls.Add(LblDescripcionPlato);
            Controls.Add(LblNombrePlato);
            Name = "FrmModificarPlatos";
            Text = "FrmModificarPlatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNombrePlato;
        private Label LblDescripcionPlato;
        private TextBox TxtNombrePlato;
        private Label LblPrecioPlato;
        private TextBox TxtPrecioPlato;
        private Button BtnAgregarPlato;
        private Button BtnCancelarPlato;
        private Button BtnEditarPlato;
        private TextBox TxtDescripcionPlato;
    }
}