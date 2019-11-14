namespace Finter
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.btnPasosCalculos = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.groupPolinomios = new System.Windows.Forms.GroupBox();
            this.opNGRegresiva = new System.Windows.Forms.RadioButton();
            this.opNGProgre = new System.Windows.Forms.RadioButton();
            this.opLagrange = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnAgregarPunto = new System.Windows.Forms.Button();
            this.btnQuitarTodos = new System.Windows.Forms.Button();
            this.btnQuitarPunto = new System.Windows.Forms.Button();
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            this.Procesar = new System.Windows.Forms.Button();
            this.btnAlterarDatos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPolinomio = new System.Windows.Forms.TextBox();
            this.btnEspecializarEnK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPolinomios.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPasosCalculos
            // 
            this.btnPasosCalculos.Enabled = false;
            this.btnPasosCalculos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasosCalculos.Location = new System.Drawing.Point(214, 358);
            this.btnPasosCalculos.Margin = new System.Windows.Forms.Padding(2);
            this.btnPasosCalculos.Name = "btnPasosCalculos";
            this.btnPasosCalculos.Size = new System.Drawing.Size(132, 44);
            this.btnPasosCalculos.TabIndex = 3;
            this.btnPasosCalculos.Text = "Pasos de cálculo";
            this.btnPasosCalculos.UseVisualStyleBackColor = true;
            this.btnPasosCalculos.Click += new System.EventHandler(this.btnPasosCalculos_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(16, 649);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(560, 31);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // groupPolinomios
            // 
            this.groupPolinomios.Controls.Add(this.opNGRegresiva);
            this.groupPolinomios.Controls.Add(this.opNGProgre);
            this.groupPolinomios.Controls.Add(this.opLagrange);
            this.groupPolinomios.Controls.Add(this.groupBox2);
            this.groupPolinomios.Location = new System.Drawing.Point(287, 151);
            this.groupPolinomios.Margin = new System.Windows.Forms.Padding(2);
            this.groupPolinomios.Name = "groupPolinomios";
            this.groupPolinomios.Padding = new System.Windows.Forms.Padding(2);
            this.groupPolinomios.Size = new System.Drawing.Size(255, 100);
            this.groupPolinomios.TabIndex = 49;
            this.groupPolinomios.TabStop = false;
            this.groupPolinomios.Text = "Polinomio Interpolante";
            // 
            // opNGRegresiva
            // 
            this.opNGRegresiva.AutoSize = true;
            this.opNGRegresiva.Location = new System.Drawing.Point(103, 60);
            this.opNGRegresiva.Margin = new System.Windows.Forms.Padding(2);
            this.opNGRegresiva.Name = "opNGRegresiva";
            this.opNGRegresiva.Size = new System.Drawing.Size(142, 23);
            this.opNGRegresiva.TabIndex = 63;
            this.opNGRegresiva.Text = "Formula Regresiva";
            this.opNGRegresiva.UseVisualStyleBackColor = true;
            // 
            // opNGProgre
            // 
            this.opNGProgre.Location = new System.Drawing.Point(103, 38);
            this.opNGProgre.Margin = new System.Windows.Forms.Padding(2);
            this.opNGProgre.Name = "opNGProgre";
            this.opNGProgre.Size = new System.Drawing.Size(125, 17);
            this.opNGProgre.TabIndex = 62;
            this.opNGProgre.Text = "Formula Progresiva";
            this.opNGProgre.UseVisualStyleBackColor = true;
            // 
            // opLagrange
            // 
            this.opLagrange.AutoSize = true;
            this.opLagrange.Checked = true;
            this.opLagrange.Location = new System.Drawing.Point(16, 47);
            this.opLagrange.Margin = new System.Windows.Forms.Padding(2);
            this.opLagrange.Name = "opLagrange";
            this.opLagrange.Size = new System.Drawing.Size(87, 23);
            this.opLagrange.TabIndex = 59;
            this.opLagrange.TabStop = true;
            this.opLagrange.Text = "Lagrange";
            this.opLagrange.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(94, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 67);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Newton Gregory";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.btnAgregarPunto);
            this.groupBox1.Location = new System.Drawing.Point(16, 151);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(183, 80);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Punto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Y: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "X: ";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(31, 47);
            this.txtY.Margin = new System.Windows.Forms.Padding(2);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(52, 26);
            this.txtY.TabIndex = 1;
            this.txtY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtY_KeyDown);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(31, 24);
            this.txtX.Margin = new System.Windows.Forms.Padding(2);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(52, 26);
            this.txtX.TabIndex = 0;
            this.txtX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtX_KeyDown);
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // btnAgregarPunto
            // 
            this.btnAgregarPunto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPunto.Location = new System.Drawing.Point(92, 24);
            this.btnAgregarPunto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPunto.Name = "btnAgregarPunto";
            this.btnAgregarPunto.Size = new System.Drawing.Size(81, 42);
            this.btnAgregarPunto.TabIndex = 2;
            this.btnAgregarPunto.Text = "Agregar Punto";
            this.btnAgregarPunto.UseVisualStyleBackColor = true;
            this.btnAgregarPunto.Click += new System.EventHandler(this.btnAgregarPunto_Click);
            // 
            // btnQuitarTodos
            // 
            this.btnQuitarTodos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarTodos.Location = new System.Drawing.Point(385, 278);
            this.btnQuitarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarTodos.Name = "btnQuitarTodos";
            this.btnQuitarTodos.Size = new System.Drawing.Size(174, 45);
            this.btnQuitarTodos.TabIndex = 47;
            this.btnQuitarTodos.Text = "Limpiar todos los puntos";
            this.btnQuitarTodos.UseVisualStyleBackColor = true;
            this.btnQuitarTodos.Click += new System.EventHandler(this.btnQuitarTodos_Click);
            // 
            // btnQuitarPunto
            // 
            this.btnQuitarPunto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPunto.Location = new System.Drawing.Point(233, 278);
            this.btnQuitarPunto.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarPunto.Name = "btnQuitarPunto";
            this.btnQuitarPunto.Size = new System.Drawing.Size(135, 45);
            this.btnQuitarPunto.TabIndex = 46;
            this.btnQuitarPunto.Text = "Quitar Punto";
            this.btnQuitarPunto.UseVisualStyleBackColor = true;
            this.btnQuitarPunto.Click += new System.EventHandler(this.btnQuitarPunto_Click);
            // 
            // dgvPuntos
            // 
            this.dgvPuntos.AllowUserToAddRows = false;
            this.dgvPuntos.AllowUserToDeleteRows = false;
            this.dgvPuntos.AllowUserToResizeColumns = false;
            this.dgvPuntos.AllowUserToResizeRows = false;
            this.dgvPuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuntos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dgvPuntos.Location = new System.Drawing.Point(16, 243);
            this.dgvPuntos.MultiSelect = false;
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.ReadOnly = true;
            this.dgvPuntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuntos.Size = new System.Drawing.Size(183, 228);
            this.dgvPuntos.TabIndex = 45;
            // 
            // Procesar
            // 
            this.Procesar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procesar.Location = new System.Drawing.Point(214, 425);
            this.Procesar.Margin = new System.Windows.Forms.Padding(2);
            this.Procesar.Name = "Procesar";
            this.Procesar.Size = new System.Drawing.Size(362, 36);
            this.Procesar.TabIndex = 50;
            this.Procesar.Text = "PROCESAR";
            this.Procesar.UseVisualStyleBackColor = true;
            this.Procesar.Click += new System.EventHandler(this.Procesar_Click);
            // 
            // btnAlterarDatos
            // 
            this.btnAlterarDatos.Enabled = false;
            this.btnAlterarDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarDatos.Location = new System.Drawing.Point(443, 358);
            this.btnAlterarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterarDatos.Name = "btnAlterarDatos";
            this.btnAlterarDatos.Size = new System.Drawing.Size(133, 44);
            this.btnAlterarDatos.TabIndex = 51;
            this.btnAlterarDatos.Text = "Alterar valores iniciales";
            this.btnAlterarDatos.UseVisualStyleBackColor = true;
            this.btnAlterarDatos.Click += new System.EventHandler(this.btnAlterarDatos_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPolinomio);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(16, 479);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(560, 164);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Polinomio Interpolante";
            // 
            // txtPolinomio
            // 
            this.txtPolinomio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPolinomio.Location = new System.Drawing.Point(7, 22);
            this.txtPolinomio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPolinomio.Multiline = true;
            this.txtPolinomio.Name = "txtPolinomio";
            this.txtPolinomio.ReadOnly = true;
            this.txtPolinomio.Size = new System.Drawing.Size(536, 127);
            this.txtPolinomio.TabIndex = 55;
            this.txtPolinomio.Text = "P(X): ";
            // 
            // btnEspecializarEnK
            // 
            this.btnEspecializarEnK.Enabled = false;
            this.btnEspecializarEnK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecializarEnK.Location = new System.Drawing.Point(350, 358);
            this.btnEspecializarEnK.Margin = new System.Windows.Forms.Padding(2);
            this.btnEspecializarEnK.Name = "btnEspecializarEnK";
            this.btnEspecializarEnK.Size = new System.Drawing.Size(89, 44);
            this.btnEspecializarEnK.TabIndex = 55;
            this.btnEspecializarEnK.Text = "P(k)";
            this.btnEspecializarEnK.UseVisualStyleBackColor = true;
            this.btnEspecializarEnK.Click += new System.EventHandler(this.btnEspecializarEnK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Finter.Properties.Resources.Finter3;
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 689);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEspecializarEnK);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnAlterarDatos);
            this.Controls.Add(this.Procesar);
            this.Controls.Add(this.groupPolinomios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuitarTodos);
            this.Controls.Add(this.btnQuitarPunto);
            this.Controls.Add(this.dgvPuntos);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnPasosCalculos);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FINTER";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.groupPolinomios.ResumeLayout(false);
            this.groupPolinomios.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.GroupBox groupPolinomios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnAgregarPunto;
        private System.Windows.Forms.Button btnQuitarTodos;
        private System.Windows.Forms.Button btnQuitarPunto;
        private System.Windows.Forms.DataGridView dgvPuntos;
        private System.Windows.Forms.Button Procesar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPolinomio;
        private System.Windows.Forms.Button btnPasosCalculos;
        private System.Windows.Forms.Button btnEspecializarEnK;
        private System.Windows.Forms.Button btnAlterarDatos;
        private System.Windows.Forms.RadioButton opLagrange;
        private System.Windows.Forms.RadioButton opNGRegresiva;
        private System.Windows.Forms.RadioButton opNGProgre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

