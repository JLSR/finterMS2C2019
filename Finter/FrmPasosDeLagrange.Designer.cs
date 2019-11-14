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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasosDeCalculos));
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblEquiespaciado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPasos
            // 
            this.txtPasos.BackColor = System.Drawing.SystemColors.Window;
            this.txtPasos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasos.Location = new System.Drawing.Point(10, 10);
            this.txtPasos.Multiline = true;
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.ReadOnly = true;
            this.txtPasos.Size = new System.Drawing.Size(915, 237);
            this.txtPasos.TabIndex = 0;
            this.txtPasos.TabStop = false;
            // 
            // lblGrado
            // 
            this.lblGrado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.Location = new System.Drawing.Point(10, 254);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(551, 20);
            this.lblGrado.TabIndex = 1;
            this.lblGrado.Text = "Grado del Polinomio: ";
            // 
            // lblEquiespaciado
            // 
            this.lblEquiespaciado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquiespaciado.Location = new System.Drawing.Point(10, 283);
            this.lblEquiespaciado.Name = "lblEquiespaciado";
            this.lblEquiespaciado.Size = new System.Drawing.Size(551, 20);
            this.lblEquiespaciado.TabIndex = 2;
            this.lblEquiespaciado.Text = "Equiespaciado: ";
            // 
            // FrmPasosDeCalculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 314);
            this.Controls.Add(this.lblEquiespaciado);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.txtPasos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmPasosDeCalculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasos de Lagrange - Finter";
            this.Load += new System.EventHandler(this.FrmPasosDeCalculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasos;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblEquiespaciado;
    }
}