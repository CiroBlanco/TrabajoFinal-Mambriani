namespace TrabajoFinal_Mambriani
{
    partial class FrmMesas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DgvMesas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvMesas).BeginInit();
            SuspendLayout();
            // 
            // DgvMesas
            // 
            DgvMesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMesas.Location = new Point(211, 31);
            DgvMesas.Name = "DgvMesas";
            DgvMesas.Size = new Size(294, 150);
            DgvMesas.TabIndex = 0;
            // 
            // FrmMesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvMesas);
            Name = "FrmMesas";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DgvMesas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvMesas;
    }
}
