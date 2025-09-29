namespace TrabajoFinal_Mambriani
{
    partial class FrmModificarBebidas
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
            TxtNombreBebida = new TextBox();
            ChkAlcoholica = new CheckBox();
            LblNombreBebida = new Label();
            LblDescripcionBebida = new Label();
            LblAlcoholicaBebida = new Label();
            LblPrecioBebida = new Label();
            TxtDescripcionBebida = new TextBox();
            TxtPrecioBebida = new TextBox();
            BtnAgregarBebida = new Button();
            BtnCancelarBebida = new Button();
            BtnEditarBebida = new Button();
            SuspendLayout();
            // 
            // TxtNombreBebida
            // 
            TxtNombreBebida.Location = new Point(28, 63);
            TxtNombreBebida.Margin = new Padding(3, 4, 3, 4);
            TxtNombreBebida.Name = "TxtNombreBebida";
            TxtNombreBebida.Size = new Size(128, 27);
            TxtNombreBebida.TabIndex = 1;
            // 
            // ChkAlcoholica
            // 
            ChkAlcoholica.AutoSize = true;
            ChkAlcoholica.Location = new Point(28, 291);
            ChkAlcoholica.Margin = new Padding(3, 4, 3, 4);
            ChkAlcoholica.Name = "ChkAlcoholica";
            ChkAlcoholica.Size = new Size(100, 24);
            ChkAlcoholica.TabIndex = 2;
            ChkAlcoholica.Text = "Alcoholica";
            ChkAlcoholica.UseVisualStyleBackColor = true;
            // 
            // LblNombreBebida
            // 
            LblNombreBebida.AutoSize = true;
            LblNombreBebida.Location = new Point(28, 39);
            LblNombreBebida.Name = "LblNombreBebida";
            LblNombreBebida.Size = new Size(71, 20);
            LblNombreBebida.TabIndex = 0;
            LblNombreBebida.Text = "Nombre:";
            // 
            // LblDescripcionBebida
            // 
            LblDescripcionBebida.AutoSize = true;
            LblDescripcionBebida.Location = new Point(28, 105);
            LblDescripcionBebida.Name = "LblDescripcionBebida";
            LblDescripcionBebida.Size = new Size(94, 20);
            LblDescripcionBebida.TabIndex = 3;
            LblDescripcionBebida.Text = "Descripción:";
            // 
            // LblAlcoholicaBebida
            // 
            LblAlcoholicaBebida.AutoSize = true;
            LblAlcoholicaBebida.Location = new Point(27, 267);
            LblAlcoholicaBebida.Name = "LblAlcoholicaBebida";
            LblAlcoholicaBebida.Size = new Size(135, 20);
            LblAlcoholicaBebida.TabIndex = 4;
            LblAlcoholicaBebida.Text = "Contiene Alcohol?";
            // 
            // LblPrecioBebida
            // 
            LblPrecioBebida.AutoSize = true;
            LblPrecioBebida.Location = new Point(28, 357);
            LblPrecioBebida.Name = "LblPrecioBebida";
            LblPrecioBebida.Size = new Size(56, 20);
            LblPrecioBebida.TabIndex = 5;
            LblPrecioBebida.Text = "Precio:";
            // 
            // TxtDescripcionBebida
            // 
            TxtDescripcionBebida.Location = new Point(28, 129);
            TxtDescripcionBebida.Margin = new Padding(3, 4, 3, 4);
            TxtDescripcionBebida.Multiline = true;
            TxtDescripcionBebida.Name = "TxtDescripcionBebida";
            TxtDescripcionBebida.Size = new Size(262, 113);
            TxtDescripcionBebida.TabIndex = 6;
            // 
            // TxtPrecioBebida
            // 
            TxtPrecioBebida.Location = new Point(28, 381);
            TxtPrecioBebida.Margin = new Padding(3, 4, 3, 4);
            TxtPrecioBebida.Multiline = true;
            TxtPrecioBebida.Name = "TxtPrecioBebida";
            TxtPrecioBebida.Size = new Size(128, 35);
            TxtPrecioBebida.TabIndex = 7;
            // 
            // BtnAgregarBebida
            // 
            BtnAgregarBebida.Location = new Point(27, 444);
            BtnAgregarBebida.Name = "BtnAgregarBebida";
            BtnAgregarBebida.Size = new Size(84, 34);
            BtnAgregarBebida.TabIndex = 9;
            BtnAgregarBebida.Text = "Agregar";
            BtnAgregarBebida.UseVisualStyleBackColor = true;
            BtnAgregarBebida.Click += BtnAgregarBebida_Click;
            // 
            // BtnCancelarBebida
            // 
            BtnCancelarBebida.Location = new Point(170, 444);
            BtnCancelarBebida.Name = "BtnCancelarBebida";
            BtnCancelarBebida.Size = new Size(84, 34);
            BtnCancelarBebida.TabIndex = 10;
            BtnCancelarBebida.Text = "Cancelar";
            BtnCancelarBebida.UseVisualStyleBackColor = true;
            BtnCancelarBebida.Click += this.BtnCancelarBebida_Click;
            // 
            // BtnEditarBebida
            // 
            BtnEditarBebida.Location = new Point(27, 484);
            BtnEditarBebida.Name = "BtnEditarBebida";
            BtnEditarBebida.Size = new Size(84, 34);
            BtnEditarBebida.TabIndex = 11;
            BtnEditarBebida.Text = "Editar";
            BtnEditarBebida.UseVisualStyleBackColor = true;
            BtnEditarBebida.Click += BtnEditarBebida_Click;
            // 
            // FrmModificarBebidas
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 525);
            Controls.Add(BtnEditarBebida);
            Controls.Add(BtnCancelarBebida);
            Controls.Add(BtnAgregarBebida);
            Controls.Add(TxtPrecioBebida);
            Controls.Add(TxtDescripcionBebida);
            Controls.Add(LblPrecioBebida);
            Controls.Add(LblAlcoholicaBebida);
            Controls.Add(LblDescripcionBebida);
            Controls.Add(ChkAlcoholica);
            Controls.Add(TxtNombreBebida);
            Controls.Add(LblNombreBebida);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmModificarBebidas";
            Text = "FrmModificarBebidas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNombreBebida;
        private CheckBox ChkAlcoholica;
        private Label LblNombreBebida;
        private Label LblDescripcionBebida;
        private Label LblAlcoholicaBebida;
        private Label LblPrecioBebida;
        private TextBox TxtDescripcionBebida;
        private TextBox TxtPrecioBebida;
        private Button BtnAgregarBebida;
        private Button BtnCancelarBebida;
        private Button BtnEditarBebida;
    }
}