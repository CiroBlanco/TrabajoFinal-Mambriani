namespace TrabajoFinal_Mambriani
{
    partial class FrmModificarChefs
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
            BtnAgregarChef = new Button();
            LblNombreChef = new Label();
            TxtNombreChef = new TextBox();
            DtpFechaNacimientoChef = new DateTimePicker();
            LblTelefonoChef = new Label();
            LblDniChef = new Label();
            TxtDniChef = new TextBox();
            TxtTelefonoChef = new TextBox();
            LblFecha_NacimientoChef = new Label();
            LblHorarioInicioChef = new Label();
            LblSectorChef = new Label();
            CmbSectorChef = new ComboBox();
            LblHorarioChefs = new Label();
            LblHorarioFinChef = new Label();
            BtnEditarChef = new Button();
            BtnCancelarChef = new Button();
            DtpHorarioInicioChef = new DateTimePicker();
            DtpHorarioFinChef = new DateTimePicker();
            SuspendLayout();
            // 
            // BtnAgregarChef
            // 
            BtnAgregarChef.Location = new Point(15, 367);
            BtnAgregarChef.Name = "BtnAgregarChef";
            BtnAgregarChef.Size = new Size(75, 23);
            BtnAgregarChef.TabIndex = 0;
            BtnAgregarChef.Text = "Agregar";
            BtnAgregarChef.UseVisualStyleBackColor = true;
            BtnAgregarChef.Click += BtnAgregarChef_Click;
            // 
            // LblNombreChef
            // 
            LblNombreChef.AutoSize = true;
            LblNombreChef.Location = new Point(12, 6);
            LblNombreChef.Name = "LblNombreChef";
            LblNombreChef.Size = new Size(107, 15);
            LblNombreChef.TabIndex = 1;
            LblNombreChef.Text = "Nombre Completo";
            // 
            // TxtNombreChef
            // 
            TxtNombreChef.Location = new Point(12, 24);
            TxtNombreChef.Name = "TxtNombreChef";
            TxtNombreChef.Size = new Size(100, 23);
            TxtNombreChef.TabIndex = 2;
            // 
            // DtpFechaNacimientoChef
            // 
            DtpFechaNacimientoChef.Format = DateTimePickerFormat.Short;
            DtpFechaNacimientoChef.Location = new Point(15, 184);
            DtpFechaNacimientoChef.Name = "DtpFechaNacimientoChef";
            DtpFechaNacimientoChef.Size = new Size(100, 23);
            DtpFechaNacimientoChef.TabIndex = 3;
            DtpFechaNacimientoChef.Value = new DateTime(2025, 9, 30, 0, 0, 0, 0);
            // 
            // LblTelefonoChef
            // 
            LblTelefonoChef.AutoSize = true;
            LblTelefonoChef.Location = new Point(12, 112);
            LblTelefonoChef.Name = "LblTelefonoChef";
            LblTelefonoChef.Size = new Size(53, 15);
            LblTelefonoChef.TabIndex = 4;
            LblTelefonoChef.Text = "Telefono";
            // 
            // LblDniChef
            // 
            LblDniChef.AutoSize = true;
            LblDniChef.Location = new Point(12, 59);
            LblDniChef.Name = "LblDniChef";
            LblDniChef.Size = new Size(30, 15);
            LblDniChef.TabIndex = 5;
            LblDniChef.Text = "DNI:";
            // 
            // TxtDniChef
            // 
            TxtDniChef.Location = new Point(12, 77);
            TxtDniChef.Name = "TxtDniChef";
            TxtDniChef.Size = new Size(100, 23);
            TxtDniChef.TabIndex = 6;
            // 
            // TxtTelefonoChef
            // 
            TxtTelefonoChef.Location = new Point(12, 130);
            TxtTelefonoChef.Name = "TxtTelefonoChef";
            TxtTelefonoChef.Size = new Size(100, 23);
            TxtTelefonoChef.TabIndex = 7;
            // 
            // LblFecha_NacimientoChef
            // 
            LblFecha_NacimientoChef.AutoSize = true;
            LblFecha_NacimientoChef.Location = new Point(12, 166);
            LblFecha_NacimientoChef.Name = "LblFecha_NacimientoChef";
            LblFecha_NacimientoChef.Size = new Size(122, 15);
            LblFecha_NacimientoChef.TabIndex = 8;
            LblFecha_NacimientoChef.Text = "Fecha de Nacimiento:";
            // 
            // LblHorarioInicioChef
            // 
            LblHorarioInicioChef.AutoSize = true;
            LblHorarioInicioChef.Location = new Point(12, 224);
            LblHorarioInicioChef.Name = "LblHorarioInicioChef";
            LblHorarioInicioChef.Size = new Size(82, 15);
            LblHorarioInicioChef.TabIndex = 9;
            LblHorarioInicioChef.Text = "Horario Inicio:";
            // 
            // LblSectorChef
            // 
            LblSectorChef.AutoSize = true;
            LblSectorChef.Location = new Point(15, 291);
            LblSectorChef.Name = "LblSectorChef";
            LblSectorChef.Size = new Size(43, 15);
            LblSectorChef.TabIndex = 10;
            LblSectorChef.Text = "Sector:";
            // 
            // CmbSectorChef
            // 
            CmbSectorChef.FormattingEnabled = true;
            CmbSectorChef.Location = new Point(15, 309);
            CmbSectorChef.Name = "CmbSectorChef";
            CmbSectorChef.Size = new Size(121, 23);
            CmbSectorChef.TabIndex = 11;
            // 
            // LblHorarioChefs
            // 
            LblHorarioChefs.AutoSize = true;
            LblHorarioChefs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblHorarioChefs.Location = new Point(105, 242);
            LblHorarioChefs.Name = "LblHorarioChefs";
            LblHorarioChefs.Size = new Size(14, 21);
            LblHorarioChefs.TabIndex = 14;
            LblHorarioChefs.Text = ":";
            // 
            // LblHorarioFinChef
            // 
            LblHorarioFinChef.AutoSize = true;
            LblHorarioFinChef.Location = new Point(127, 224);
            LblHorarioFinChef.Name = "LblHorarioFinChef";
            LblHorarioFinChef.Size = new Size(69, 15);
            LblHorarioFinChef.TabIndex = 15;
            LblHorarioFinChef.Text = "Horario Fin:";
            // 
            // BtnEditarChef
            // 
            BtnEditarChef.Location = new Point(15, 405);
            BtnEditarChef.Name = "BtnEditarChef";
            BtnEditarChef.Size = new Size(75, 23);
            BtnEditarChef.TabIndex = 16;
            BtnEditarChef.Text = "Editar";
            BtnEditarChef.UseVisualStyleBackColor = true;
            BtnEditarChef.Click += BtnEditarChef_Click;
            // 
            // BtnCancelarChef
            // 
            BtnCancelarChef.Location = new Point(121, 367);
            BtnCancelarChef.Name = "BtnCancelarChef";
            BtnCancelarChef.Size = new Size(75, 23);
            BtnCancelarChef.TabIndex = 17;
            BtnCancelarChef.Text = "Cancelar";
            BtnCancelarChef.UseVisualStyleBackColor = true;
            BtnCancelarChef.Click += this.BtnCancelarChef_Click;
            // 
            // DtpHorarioInicioChef
            // 
            DtpHorarioInicioChef.Format = DateTimePickerFormat.Time;
            DtpHorarioInicioChef.Location = new Point(12, 242);
            DtpHorarioInicioChef.Name = "DtpHorarioInicioChef";
            DtpHorarioInicioChef.Size = new Size(85, 23);
            DtpHorarioInicioChef.TabIndex = 18;
            DtpHorarioInicioChef.Value = new DateTime(2025, 9, 30, 0, 0, 0, 0);
            // 
            // DtpHorarioFinChef
            // 
            DtpHorarioFinChef.Format = DateTimePickerFormat.Time;
            DtpHorarioFinChef.Location = new Point(125, 242);
            DtpHorarioFinChef.Name = "DtpHorarioFinChef";
            DtpHorarioFinChef.Size = new Size(85, 23);
            DtpHorarioFinChef.TabIndex = 19;
            DtpHorarioFinChef.Value = new DateTime(2025, 9, 30, 0, 0, 0, 0);
            // 
            // FrmModificarChefs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 433);
            Controls.Add(DtpHorarioFinChef);
            Controls.Add(DtpHorarioInicioChef);
            Controls.Add(BtnCancelarChef);
            Controls.Add(BtnEditarChef);
            Controls.Add(LblHorarioFinChef);
            Controls.Add(LblHorarioChefs);
            Controls.Add(CmbSectorChef);
            Controls.Add(LblSectorChef);
            Controls.Add(LblHorarioInicioChef);
            Controls.Add(LblFecha_NacimientoChef);
            Controls.Add(TxtTelefonoChef);
            Controls.Add(TxtDniChef);
            Controls.Add(LblDniChef);
            Controls.Add(LblTelefonoChef);
            Controls.Add(DtpFechaNacimientoChef);
            Controls.Add(TxtNombreChef);
            Controls.Add(LblNombreChef);
            Controls.Add(BtnAgregarChef);
            Name = "FrmModificarChefs";
            Text = "FrmModificarChefs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAgregarChef;
        private Label LblNombreChef;
        private TextBox TxtNombreChef;
        private DateTimePicker DtpFechaNacimientoChef;
        private Label LblTelefonoChef;
        private Label LblDniChef;
        private TextBox TxtDniChef;
        private TextBox TxtTelefonoChef;
        private Label LblFecha_NacimientoChef;
        private Label LblHorarioInicioChef;
        private Label LblSectorChef;
        private ComboBox CmbSectorChef;
        private Label LblHorarioChefs;
        private Label LblHorarioFinChef;
        private Button BtnEditarChef;
        private Button BtnCancelarChef;
        private DateTimePicker DtpHorarioInicioChef;
        private DateTimePicker DtpHorarioFinChef;
    }
}