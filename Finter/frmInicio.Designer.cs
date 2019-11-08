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
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAlterarDatos = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.opNGRegresiva = new System.Windows.Forms.RadioButton();
            this.opNGProgre = new System.Windows.Forms.RadioButton();
            this.opLagrange = new System.Windows.Forms.RadioButton();
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
            this.Procesar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterarDatos
            // 
            this.btnAlterarDatos.Enabled = false;
            this.btnAlterarDatos.Location = new System.Drawing.Point(47, 354);
            this.btnAlterarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterarDatos.Name = "btnAlterarDatos";
            this.btnAlterarDatos.Size = new System.Drawing.Size(89, 36);
            this.btnAlterarDatos.TabIndex = 3;
            this.btnAlterarDatos.Text = "Alterar valores iniciales";
            this.btnAlterarDatos.UseVisualStyleBackColor = true;
            this.btnAlterarDatos.Click += new System.EventHandler(this.btnAlterarDatos_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(420, 354);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(89, 36);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opNGRegresiva);
            this.groupBox2.Controls.Add(this.opNGProgre);
            this.groupBox2.Controls.Add(this.opLagrange);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(319, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(190, 163);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Polinomio Interpolante";
            // 
            // opNGRegresiva
            // 
            this.opNGRegresiva.AutoSize = true;
            this.opNGRegresiva.Location = new System.Drawing.Point(34, 94);
            this.opNGRegresiva.Margin = new System.Windows.Forms.Padding(2);
            this.opNGRegresiva.Name = "opNGRegresiva";
            this.opNGRegresiva.Size = new System.Drawing.Size(113, 17);
            this.opNGRegresiva.TabIndex = 51;
            this.opNGRegresiva.Text = "Formula Regresiva";
            this.opNGRegresiva.UseVisualStyleBackColor = true;
            this.opNGRegresiva.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // opNGProgre
            // 
            this.opNGProgre.AutoSize = true;
            this.opNGProgre.Location = new System.Drawing.Point(34, 72);
            this.opNGProgre.Margin = new System.Windows.Forms.Padding(2);
            this.opNGProgre.Name = "opNGProgre";
            this.opNGProgre.Size = new System.Drawing.Size(115, 17);
            this.opNGProgre.TabIndex = 50;
            this.opNGProgre.Text = "Formula Progresiva";
            this.opNGProgre.UseVisualStyleBackColor = true;
            // 
            // opLagrange
            // 
            this.opLagrange.AutoSize = true;
            this.opLagrange.Checked = true;
            this.opLagrange.Location = new System.Drawing.Point(15, 28);
            this.opLagrange.Margin = new System.Windows.Forms.Padding(2);
            this.opLagrange.Name = "opLagrange";
            this.opLagrange.Size = new System.Drawing.Size(70, 17);
            this.opLagrange.TabIndex = 48;
            this.opLagrange.TabStop = true;
            this.opLagrange.Text = "Lagrange";
            this.opLagrange.UseVisualStyleBackColor = true;
            this.opLagrange.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(15, 52);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(141, 74);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 10);
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
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Y: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "X: ";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(31, 47);
            this.txtY.Margin = new System.Windows.Forms.Padding(2);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(52, 20);
            this.txtY.TabIndex = 1;
            this.txtY.TextChanged += new System.EventHandler(this.txtY_TextChanged);
            this.txtY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtY_KeyDown);
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(31, 24);
            this.txtX.Margin = new System.Windows.Forms.Padding(2);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(52, 20);
            this.txtX.TabIndex = 0;
            this.txtX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtX_KeyDown);
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // btnAgregarPunto
            // 
            this.btnAgregarPunto.Location = new System.Drawing.Point(93, 24);
            this.btnAgregarPunto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPunto.Name = "btnAgregarPunto";
            this.btnAgregarPunto.Size = new System.Drawing.Size(81, 41);
            this.btnAgregarPunto.TabIndex = 2;
            this.btnAgregarPunto.Text = "Agregar Punto";
            this.btnAgregarPunto.UseVisualStyleBackColor = true;
            this.btnAgregarPunto.Click += new System.EventHandler(this.btnAgregarPunto_Click);
            // 
            // btnQuitarTodos
            // 
            this.btnQuitarTodos.Location = new System.Drawing.Point(214, 160);
            this.btnQuitarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarTodos.Name = "btnQuitarTodos";
            this.btnQuitarTodos.Size = new System.Drawing.Size(80, 32);
            this.btnQuitarTodos.TabIndex = 47;
            this.btnQuitarTodos.Text = "Quitar Todos";
            this.btnQuitarTodos.UseVisualStyleBackColor = true;
            this.btnQuitarTodos.Click += new System.EventHandler(this.btnQuitarTodos_Click);
            // 
            // btnQuitarPunto
            // 
            this.btnQuitarPunto.Location = new System.Drawing.Point(214, 124);
            this.btnQuitarPunto.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarPunto.Name = "btnQuitarPunto";
            this.btnQuitarPunto.Size = new System.Drawing.Size(80, 32);
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
            this.dgvPuntos.Location = new System.Drawing.Point(16, 102);
            this.dgvPuntos.MultiSelect = false;
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.ReadOnly = true;
            this.dgvPuntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuntos.Size = new System.Drawing.Size(183, 228);
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
            // Procesar
            // 
            this.Procesar.Location = new System.Drawing.Point(205, 354);
            this.Procesar.Margin = new System.Windows.Forms.Padding(2);
            this.Procesar.Name = "Procesar";
            this.Procesar.Size = new System.Drawing.Size(89, 36);
            this.Procesar.TabIndex = 50;
            this.Procesar.Text = "Procesar";
            this.Procesar.UseVisualStyleBackColor = true;
            this.Procesar.Click += new System.EventHandler(this.Procesar_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 430);
            this.Controls.Add(this.Procesar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuitarTodos);
            this.Controls.Add(this.btnQuitarPunto);
            this.Controls.Add(this.dgvPuntos);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAlterarDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmInicio";
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

        private System.Windows.Forms.Button btnAlterarDatos;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton opLagrange;
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
        private System.Windows.Forms.RadioButton opNGRegresiva;
        private System.Windows.Forms.RadioButton opNGProgre;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Button Procesar;
    }
}

