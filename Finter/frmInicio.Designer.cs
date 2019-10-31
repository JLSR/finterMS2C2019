namespace Finter
{
    partial class frmInicio
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
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPasosCalculos = new System.Windows.Forms.Button();
            this.btnEspecializarEnK = new System.Windows.Forms.Button();
            this.btnAlterarDatos = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnFinIngreso = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnAgregarPunto = new System.Windows.Forms.Button();
            this.btnQuitarTodos = new System.Windows.Forms.Button();
            this.btnQuitarPunto = new System.Windows.Forms.Button();
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPasosCalculos
            // 
            this.btnPasosCalculos.Enabled = false;
            this.btnPasosCalculos.Location = new System.Drawing.Point(21, 436);
            this.btnPasosCalculos.Name = "btnPasosCalculos";
            this.btnPasosCalculos.Size = new System.Drawing.Size(119, 44);
            this.btnPasosCalculos.TabIndex = 1;
            this.btnPasosCalculos.Text = "Pasos de calculo";
            this.btnPasosCalculos.UseVisualStyleBackColor = true;
            // 
            // btnEspecializarEnK
            // 
            this.btnEspecializarEnK.Enabled = false;
            this.btnEspecializarEnK.Location = new System.Drawing.Point(145, 436);
            this.btnEspecializarEnK.Name = "btnEspecializarEnK";
            this.btnEspecializarEnK.Size = new System.Drawing.Size(119, 44);
            this.btnEspecializarEnK.TabIndex = 2;
            this.btnEspecializarEnK.Text = "P(k)";
            this.btnEspecializarEnK.UseVisualStyleBackColor = true;
            // 
            // btnAlterarDatos
            // 
            this.btnAlterarDatos.Enabled = false;
            this.btnAlterarDatos.Location = new System.Drawing.Point(270, 436);
            this.btnAlterarDatos.Name = "btnAlterarDatos";
            this.btnAlterarDatos.Size = new System.Drawing.Size(119, 44);
            this.btnAlterarDatos.TabIndex = 3;
            this.btnAlterarDatos.Text = "Alterar valores iniciales";
            this.btnAlterarDatos.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(481, 436);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(119, 44);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnFinIngreso
            // 
            this.btnFinIngreso.Location = new System.Drawing.Point(281, 59);
            this.btnFinIngreso.Name = "btnFinIngreso";
            this.btnFinIngreso.Size = new System.Drawing.Size(111, 39);
            this.btnFinIngreso.TabIndex = 50;
            this.btnFinIngreso.Text = "Fin de ingreso";
            this.btnFinIngreso.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(425, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 160);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Polinomio Interpolante";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(46, 116);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(148, 21);
            this.radioButton4.TabIndex = 51;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Formula Regresiva";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(46, 89);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(152, 21);
            this.radioButton3.TabIndex = 50;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Formula Progresiva";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 21);
            this.radioButton1.TabIndex = 48;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Lagrange";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(31, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 91);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Newton Gregory";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.btnAgregarPunto);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 98);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Punto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Y: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "X: ";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(41, 58);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(68, 22);
            this.txtY.TabIndex = 42;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(41, 30);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(68, 22);
            this.txtX.TabIndex = 41;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // btnAgregarPunto
            // 
            this.btnAgregarPunto.Location = new System.Drawing.Point(124, 41);
            this.btnAgregarPunto.Name = "btnAgregarPunto";
            this.btnAgregarPunto.Size = new System.Drawing.Size(108, 39);
            this.btnAgregarPunto.TabIndex = 40;
            this.btnAgregarPunto.Text = "Agregar Punto";
            this.btnAgregarPunto.UseVisualStyleBackColor = true;
            this.btnAgregarPunto.Click += new System.EventHandler(this.btnAgregarPunto_Click);
            // 
            // btnQuitarTodos
            // 
            this.btnQuitarTodos.Location = new System.Drawing.Point(289, 197);
            this.btnQuitarTodos.Name = "btnQuitarTodos";
            this.btnQuitarTodos.Size = new System.Drawing.Size(103, 39);
            this.btnQuitarTodos.TabIndex = 47;
            this.btnQuitarTodos.Text = "Quitar Todos";
            this.btnQuitarTodos.UseVisualStyleBackColor = true;
            this.btnQuitarTodos.Click += new System.EventHandler(this.btnQuitarTodos_Click);
            // 
            // btnQuitarPunto
            // 
            this.btnQuitarPunto.Location = new System.Drawing.Point(286, 152);
            this.btnQuitarPunto.Name = "btnQuitarPunto";
            this.btnQuitarPunto.Size = new System.Drawing.Size(106, 39);
            this.btnQuitarPunto.TabIndex = 46;
            this.btnQuitarPunto.Text = "Quitar Punto";
            this.btnQuitarPunto.UseVisualStyleBackColor = true;
            this.btnQuitarPunto.Click += new System.EventHandler(this.btnQuitarPunto_Click);
            // 
            // dgvPuntos
            // 
            this.dgvPuntos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuntos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dgvPuntos.Location = new System.Drawing.Point(21, 125);
            this.dgvPuntos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPuntos.MultiSelect = false;
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.ReadOnly = true;
            this.dgvPuntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuntos.Size = new System.Drawing.Size(244, 281);
            this.dgvPuntos.TabIndex = 45;
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
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 509);
            this.Controls.Add(this.btnFinIngreso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuitarTodos);
            this.Controls.Add(this.btnQuitarPunto);
            this.Controls.Add(this.dgvPuntos);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAlterarDatos);
            this.Controls.Add(this.btnEspecializarEnK);
            this.Controls.Add(this.btnPasosCalculos);
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FINTER";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPasosCalculos;
        private System.Windows.Forms.Button btnEspecializarEnK;
        private System.Windows.Forms.Button btnAlterarDatos;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnFinIngreso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnAgregarPunto;
        private System.Windows.Forms.Button btnQuitarTodos;
        private System.Windows.Forms.Button btnQuitarPunto;
        private System.Windows.Forms.DataGridView dgvPuntos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

