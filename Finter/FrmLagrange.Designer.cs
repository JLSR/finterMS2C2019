namespace Finter
{
    partial class FrmLagrange
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
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.chkPasos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(63, 22);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(447, 23);
            this.txtFuncion.TabIndex = 0;
            // 
            // chkPasos
            // 
            this.chkPasos.AutoSize = true;
            this.chkPasos.Location = new System.Drawing.Point(533, 24);
            this.chkPasos.Name = "chkPasos";
            this.chkPasos.Size = new System.Drawing.Size(100, 19);
            this.chkPasos.TabIndex = 1;
            this.chkPasos.Text = "Mostrar Pasos";
            this.chkPasos.UseVisualStyleBackColor = true;
            this.chkPasos.CheckedChanged += new System.EventHandler(this.chkPasos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "P(k) =";
            // 
            // txtPasos
            // 
            this.txtPasos.Location = new System.Drawing.Point(18, 76);
            this.txtPasos.Multiline = true;
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPasos.Size = new System.Drawing.Size(626, 365);
            this.txtPasos.TabIndex = 3;
            // 
            // FrmLagrange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 466);
            this.Controls.Add(this.txtPasos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkPasos);
            this.Controls.Add(this.txtFuncion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLagrange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lagrange";
            this.Load += new System.EventHandler(this.FrmLagrange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.CheckBox chkPasos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasos;
    }
}