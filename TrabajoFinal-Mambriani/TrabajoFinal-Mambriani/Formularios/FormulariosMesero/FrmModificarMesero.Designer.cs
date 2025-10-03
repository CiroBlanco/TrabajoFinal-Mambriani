namespace TrabajoFinal_Mambriani
{
    partial class FrmModificarMesero
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
            LblNombreMesero = new Label();
            TxtNombreMesero = new TextBox();
            LblDniMesero = new Label();
            LblTelefonoMesero = new Label();
            TxtDniMesero = new TextBox();
            TxtTelefonoMesero = new TextBox();
            LblFechaNacimientoMesero = new Label();
            LblHorarioEntradaMesero = new Label();
            LblHorarioSalidaMesero = new Label();
            LblSectorMesero = new Label();
            DtpFechaNacimientoMesero = new DateTimePicker();
            DtpHorarioFinMesero = new DateTimePicker();
            DtpHorarioInicioMesero = new DateTimePicker();
            CmbSectorMesero = new ComboBox();
            BtnAgregarMesero = new Button();
            BtnEditarMesero = new Button();
            BtnCancelarMesero = new Button();
            SuspendLayout();
            // 
            // LblNombreMesero
            // 
            LblNombreMesero.AutoSize = true;
            LblNombreMesero.Location = new Point(21, 26);
            LblNombreMesero.Name = "LblNombreMesero";
            LblNombreMesero.Size = new Size(110, 15);
            LblNombreMesero.TabIndex = 0;
            LblNombreMesero.Text = "Nombre Completo:";
            // 
            // TxtNombreMesero
            // 
            TxtNombreMesero.Location = new Point(21, 44);
            TxtNombreMesero.Name = "TxtNombreMesero";
            TxtNombreMesero.Size = new Size(100, 23);
            TxtNombreMesero.TabIndex = 1;
            // 
            // LblDniMesero
            // 
            LblDniMesero.AutoSize = true;
            LblDniMesero.Location = new Point(21, 70);
            LblDniMesero.Name = "LblDniMesero";
            LblDniMesero.Size = new Size(27, 15);
            LblDniMesero.TabIndex = 2;
            LblDniMesero.Text = "DNI";
            // 
            // LblTelefonoMesero
            // 
            LblTelefonoMesero.AutoSize = true;
            LblTelefonoMesero.Location = new Point(21, 114);
            LblTelefonoMesero.Name = "LblTelefonoMesero";
            LblTelefonoMesero.Size = new Size(52, 15);
            LblTelefonoMesero.TabIndex = 3;
            LblTelefonoMesero.Text = "Telefono";
            // 
            // TxtDniMesero
            // 
            TxtDniMesero.Location = new Point(21, 88);
            TxtDniMesero.Name = "TxtDniMesero";
            TxtDniMesero.Size = new Size(100, 23);
            TxtDniMesero.TabIndex = 4;
            // 
            // TxtTelefonoMesero
            // 
            TxtTelefonoMesero.Location = new Point(21, 132);
            TxtTelefonoMesero.Name = "TxtTelefonoMesero";
            TxtTelefonoMesero.Size = new Size(100, 23);
            TxtTelefonoMesero.TabIndex = 5;
            // 
            // LblFechaNacimientoMesero
            // 
            LblFechaNacimientoMesero.AutoSize = true;
            LblFechaNacimientoMesero.Location = new Point(21, 158);
            LblFechaNacimientoMesero.Name = "LblFechaNacimientoMesero";
            LblFechaNacimientoMesero.Size = new Size(119, 15);
            LblFechaNacimientoMesero.TabIndex = 7;
            LblFechaNacimientoMesero.Text = "Fecha de Nacimiento";
            // 
            // LblHorarioEntradaMesero
            // 
            LblHorarioEntradaMesero.AutoSize = true;
            LblHorarioEntradaMesero.Location = new Point(21, 202);
            LblHorarioEntradaMesero.Name = "LblHorarioEntradaMesero";
            LblHorarioEntradaMesero.Size = new Size(106, 15);
            LblHorarioEntradaMesero.TabIndex = 8;
            LblHorarioEntradaMesero.Text = "Horario de Entrada";
            // 
            // LblHorarioSalidaMesero
            // 
            LblHorarioSalidaMesero.AutoSize = true;
            LblHorarioSalidaMesero.Location = new Point(161, 202);
            LblHorarioSalidaMesero.Name = "LblHorarioSalidaMesero";
            LblHorarioSalidaMesero.Size = new Size(97, 15);
            LblHorarioSalidaMesero.TabIndex = 9;
            LblHorarioSalidaMesero.Text = "Horario de Salida";
            // 
            // LblSectorMesero
            // 
            LblSectorMesero.AutoSize = true;
            LblSectorMesero.Location = new Point(21, 246);
            LblSectorMesero.Name = "LblSectorMesero";
            LblSectorMesero.Size = new Size(40, 15);
            LblSectorMesero.TabIndex = 10;
            LblSectorMesero.Text = "Sector";
            // 
            // DtpFechaNacimientoMesero
            // 
            DtpFechaNacimientoMesero.Format = DateTimePickerFormat.Short;
            DtpFechaNacimientoMesero.Location = new Point(21, 176);
            DtpFechaNacimientoMesero.Name = "DtpFechaNacimientoMesero";
            DtpFechaNacimientoMesero.Size = new Size(131, 23);
            DtpFechaNacimientoMesero.TabIndex = 11;
            // 
            // DtpHorarioFinMesero
            // 
            DtpHorarioFinMesero.Format = DateTimePickerFormat.Time;
            DtpHorarioFinMesero.Location = new Point(161, 220);
            DtpHorarioFinMesero.Name = "DtpHorarioFinMesero";
            DtpHorarioFinMesero.Size = new Size(107, 23);
            DtpHorarioFinMesero.TabIndex = 12;
            // 
            // DtpHorarioInicioMesero
            // 
            DtpHorarioInicioMesero.Format = DateTimePickerFormat.Time;
            DtpHorarioInicioMesero.Location = new Point(21, 220);
            DtpHorarioInicioMesero.Name = "DtpHorarioInicioMesero";
            DtpHorarioInicioMesero.Size = new Size(106, 23);
            DtpHorarioInicioMesero.TabIndex = 13;
            // 
            // CmbSectorMesero
            // 
            CmbSectorMesero.FormattingEnabled = true;
            CmbSectorMesero.Location = new Point(21, 264);
            CmbSectorMesero.Name = "CmbSectorMesero";
            CmbSectorMesero.Size = new Size(121, 23);
            CmbSectorMesero.TabIndex = 14;
            // 
            // BtnAgregarMesero
            // 
            BtnAgregarMesero.Location = new Point(21, 306);
            BtnAgregarMesero.Name = "BtnAgregarMesero";
            BtnAgregarMesero.Size = new Size(75, 23);
            BtnAgregarMesero.TabIndex = 15;
            BtnAgregarMesero.Text = "Agregar";
            BtnAgregarMesero.UseVisualStyleBackColor = true;
            BtnAgregarMesero.Click += BtnAgregarMesero_Click;
            // 
            // BtnEditarMesero
            // 
            BtnEditarMesero.Location = new Point(102, 306);
            BtnEditarMesero.Name = "BtnEditarMesero";
            BtnEditarMesero.Size = new Size(75, 23);
            BtnEditarMesero.TabIndex = 16;
            BtnEditarMesero.Text = "Editar";
            BtnEditarMesero.UseVisualStyleBackColor = true;
            BtnEditarMesero.Click += this.BtnEditarMesero_Click;
            // 
            // BtnCancelarMesero
            // 
            BtnCancelarMesero.Location = new Point(183, 306);
            BtnCancelarMesero.Name = "BtnCancelarMesero";
            BtnCancelarMesero.Size = new Size(75, 23);
            BtnCancelarMesero.TabIndex = 17;
            BtnCancelarMesero.Text = "Cancelar";
            BtnCancelarMesero.UseVisualStyleBackColor = true;
            BtnCancelarMesero.Click += BtnCancelarMesero_Click;
            // 
            // FrmModificarMesero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 337);
            Controls.Add(BtnCancelarMesero);
            Controls.Add(BtnEditarMesero);
            Controls.Add(BtnAgregarMesero);
            Controls.Add(CmbSectorMesero);
            Controls.Add(DtpHorarioInicioMesero);
            Controls.Add(DtpHorarioFinMesero);
            Controls.Add(DtpFechaNacimientoMesero);
            Controls.Add(LblSectorMesero);
            Controls.Add(LblHorarioSalidaMesero);
            Controls.Add(LblHorarioEntradaMesero);
            Controls.Add(LblFechaNacimientoMesero);
            Controls.Add(TxtTelefonoMesero);
            Controls.Add(TxtDniMesero);
            Controls.Add(LblTelefonoMesero);
            Controls.Add(LblDniMesero);
            Controls.Add(TxtNombreMesero);
            Controls.Add(LblNombreMesero);
            Name = "FrmModificarMesero";
            Text = "FrmModificarMesero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNombreMesero;
        private TextBox TxtNombreMesero;
        private Label LblDniMesero;
        private Label LblTelefonoMesero;
        private TextBox TxtDniMesero;
        private TextBox TxtTelefonoMesero;
        private Label LblFechaNacimientoMesero;
        private Label LblHorarioEntradaMesero;
        private Label LblHorarioSalidaMesero;
        private Label LblSectorMesero;
        private DateTimePicker DtpFechaNacimientoMesero;
        private DateTimePicker DtpHorarioFinMesero;
        private DateTimePicker DtpHorarioInicioMesero;
        private ComboBox CmbSectorMesero;
        private Button BtnAgregarMesero;
        private Button BtnEditarMesero;
        private Button BtnCancelarMesero;
    }
}