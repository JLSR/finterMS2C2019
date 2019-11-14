namespace Finter
{
    partial class FrmPasosDeCalculosNG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasosDeCalculosNG));
            this.dgvPasos = new System.Windows.Forms.DataGridView();
            this.txtCountLdL = new System.Windows.Forms.TextBox();
            this.lblGradoP = new System.Windows.Forms.Label();
            this.lblEquiespacio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPasos
            // 
            this.dgvPasos.AllowUserToAddRows = false;
            this.dgvPasos.AllowUserToDeleteRows = false;
            this.dgvPasos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPasos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvPasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasos.Location = new System.Drawing.Point(13, 14);
            this.dgvPasos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPasos.MultiSelect = false;
            this.dgvPasos.Name = "dgvPasos";
            this.dgvPasos.ReadOnly = true;
            this.dgvPasos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasos.Size = new System.Drawing.Size(732, 290);
            this.dgvPasos.TabIndex = 46;
            // 
            // txtCountLdL
            // 
            this.txtCountLdL.Location = new System.Drawing.Point(610, 427);
            this.txtCountLdL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCountLdL.Name = "txtCountLdL";
            this.txtCountLdL.Size = new System.Drawing.Size(100, 22);
            this.txtCountLdL.TabIndex = 47;
            // 
            // lblGradoP
            // 
            this.lblGradoP.AutoSize = true;
            this.lblGradoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradoP.Location = new System.Drawing.Point(12, 324);
            this.lblGradoP.Name = "lblGradoP";
            this.lblGradoP.Size = new System.Drawing.Size(198, 25);
            this.lblGradoP.TabIndex = 48;
            this.lblGradoP.Text = "Grado del Polinomio: ";
            // 
            // lblEquiespacio
            // 
            this.lblEquiespacio.AutoSize = true;
            this.lblEquiespacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquiespacio.Location = new System.Drawing.Point(12, 359);
            this.lblEquiespacio.Name = "lblEquiespacio";
            this.lblEquiespacio.Size = new System.Drawing.Size(152, 25);
            this.lblEquiespacio.TabIndex = 49;
            this.lblEquiespacio.Text = "Equiespaciado: ";
            // 
            // FrmPasosDeCalculosNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 395);
            this.Controls.Add(this.lblEquiespacio);
            this.Controls.Add(this.lblGradoP);
            this.Controls.Add(this.txtCountLdL);
            this.Controls.Add(this.dgvPasos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmPasosDeCalculosNG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasos de Newton - Finter";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCountLdL;
        public System.Windows.Forms.DataGridView dgvPasos;
        public System.Windows.Forms.Label lblGradoP;
        public System.Windows.Forms.Label lblEquiespacio;
    }
}