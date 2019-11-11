namespace Finter
{
    partial class FrmPasosDeCalculos
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
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPasos
            // 
            this.txtPasos.BackColor = System.Drawing.SystemColors.Window;
            this.txtPasos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasos.Location = new System.Drawing.Point(10, 10);
            this.txtPasos.Multiline = true;
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.ReadOnly = true;
            this.txtPasos.Size = new System.Drawing.Size(552, 237);
            this.txtPasos.TabIndex = 0;
            this.txtPasos.TabStop = false;
            // 
            // FrmPasosDeCalculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 257);
            this.Controls.Add(this.txtPasos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmPasosDeCalculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasos de Lagrange";
            this.Load += new System.EventHandler(this.FrmPasosDeCalculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasos;
    }
}