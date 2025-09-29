namespace TrabajoFinal_Mambriani
{
    partial class FrmModificarMesas
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
            TxtCantidadPersonas = new TextBox();
            CmbSector = new ComboBox();
            ChkLibre = new CheckBox();
            LblCantidadPersonas = new Label();
            LblLibre = new Label();
            LblSector = new Label();
            ChkOcupado = new CheckBox();
            BtnAgregarMesa = new Button();
            BtnEditarMesa = new Button();
            BtnCancelar = new Button();
            SuspendLayout();
            // 
            // TxtCantidadPersonas
            // 
            TxtCantidadPersonas.Location = new Point(32, 44);
            TxtCantidadPersonas.Margin = new Padding(4, 3, 4, 3);
            TxtCantidadPersonas.Name = "TxtCantidadPersonas";
            TxtCantidadPersonas.Size = new Size(128, 26);
            TxtCantidadPersonas.TabIndex = 1;
            // 
            // CmbSector
            // 
            CmbSector.FormattingEnabled = true;
            CmbSector.Location = new Point(32, 198);
            CmbSector.Margin = new Padding(4, 3, 4, 3);
            CmbSector.Name = "CmbSector";
            CmbSector.Size = new Size(155, 26);
            CmbSector.TabIndex = 2;
            // 
            // ChkLibre
            // 
            ChkLibre.AutoSize = true;
            ChkLibre.Location = new Point(34, 108);
            ChkLibre.Margin = new Padding(4, 3, 4, 3);
            ChkLibre.Name = "ChkLibre";
            ChkLibre.Size = new Size(60, 22);
            ChkLibre.TabIndex = 3;
            ChkLibre.Text = "Libre";
            ChkLibre.UseVisualStyleBackColor = true;
            // 
            // LblCantidadPersonas
            // 
            LblCantidadPersonas.AutoSize = true;
            LblCantidadPersonas.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCantidadPersonas.Location = new Point(32, 23);
            LblCantidadPersonas.Margin = new Padding(4, 0, 4, 0);
            LblCantidadPersonas.Name = "LblCantidadPersonas";
            LblCantidadPersonas.Size = new Size(147, 18);
            LblCantidadPersonas.TabIndex = 0;
            LblCantidadPersonas.Text = "Cantidad Personas:";
            // 
            // LblLibre
            // 
            LblLibre.AutoSize = true;
            LblLibre.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLibre.Location = new Point(34, 87);
            LblLibre.Margin = new Padding(4, 0, 4, 0);
            LblLibre.Name = "LblLibre";
            LblLibre.Size = new Size(60, 18);
            LblLibre.TabIndex = 4;
            LblLibre.Text = "Estado:";
            // 
            // LblSector
            // 
            LblSector.AutoSize = true;
            LblSector.Font = new Font("Constantia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSector.Location = new Point(34, 177);
            LblSector.Margin = new Padding(4, 0, 4, 0);
            LblSector.Name = "LblSector";
            LblSector.Size = new Size(57, 18);
            LblSector.TabIndex = 5;
            LblSector.Text = "Sector:";
            // 
            // ChkOcupado
            // 
            ChkOcupado.AutoSize = true;
            ChkOcupado.Location = new Point(34, 126);
            ChkOcupado.Margin = new Padding(4, 3, 4, 3);
            ChkOcupado.Name = "ChkOcupado";
            ChkOcupado.Size = new Size(86, 22);
            ChkOcupado.TabIndex = 6;
            ChkOcupado.Text = "Ocupada";
            ChkOcupado.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarMesa
            // 
            BtnAgregarMesa.Location = new Point(16, 257);
            BtnAgregarMesa.Margin = new Padding(4, 3, 4, 3);
            BtnAgregarMesa.Name = "BtnAgregarMesa";
            BtnAgregarMesa.Size = new Size(130, 28);
            BtnAgregarMesa.TabIndex = 7;
            BtnAgregarMesa.Text = "Agregar Mesa";
            BtnAgregarMesa.UseVisualStyleBackColor = true;
            BtnAgregarMesa.Click += BtnAgregarMesa_Click;
            // 
            // BtnEditarMesa
            // 
            BtnEditarMesa.Location = new Point(16, 257);
            BtnEditarMesa.Margin = new Padding(4, 3, 4, 3);
            BtnEditarMesa.Name = "BtnEditarMesa";
            BtnEditarMesa.Size = new Size(130, 28);
            BtnEditarMesa.TabIndex = 8;
            BtnEditarMesa.Text = "Editar Mesa";
            BtnEditarMesa.UseVisualStyleBackColor = true;
            BtnEditarMesa.Click += BtnEditarMesa_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(205, 257);
            BtnCancelar.Margin = new Padding(4, 3, 4, 3);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(97, 28);
            BtnCancelar.TabIndex = 9;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // FrmModificarMesas
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(317, 335);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnEditarMesa);
            Controls.Add(BtnAgregarMesa);
            Controls.Add(ChkOcupado);
            Controls.Add(LblSector);
            Controls.Add(LblLibre);
            Controls.Add(ChkLibre);
            Controls.Add(CmbSector);
            Controls.Add(TxtCantidadPersonas);
            Controls.Add(LblCantidadPersonas);
            Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmModificarMesas";
            Text = "FrmModificarMesas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtCantidadPersonas;
        private ComboBox CmbSector;
        private CheckBox ChkLibre;
        private Label LblCantidadPersonas;
        private Label LblLibre;
        private Label LblSector;
        private CheckBox ChkOcupado;
        private Button BtnAgregarMesa;
        private Button BtnEditarMesa;
        private Button BtnCancelar;
    }
}