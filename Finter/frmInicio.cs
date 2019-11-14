using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Finter
{
    public partial class FrmInicio : Form
    {
        private List<KeyValuePair<double, double>> _valores;
        private Lagrange _lagrange;
        private Ng _ng;
        private readonly string _pxString = "P(X): ";

        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnAgregarPunto_Click(object sender, EventArgs e)
        {
            AgregarParValores();
        }

        private void AgregarParValores()
        {
            if (txtX.Text != "" && txtY.Text != "")
            {
                if (Double.Parse(txtY.Text) != 0)
                {
                    var x = double.Parse(txtX.Text);
                    var y = double.Parse(txtY.Text);

                    dgvPuntos.Rows.Add(x, y);

                    txtX.Clear();
                    txtY.Clear();
                    txtX.Focus();
                }
                else
                {
                    MessageBox.Show("La Coordenada Y no puede tomar por valor el cero.",
                        "Valor no permitido en coordenada Y", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Coordenada X o Coordenada Y vacía. Inserte ambos valores de las coordenadas.",
                    "Coordenadas vacías", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
        }

        private void btnQuitarPunto_Click(object sender, EventArgs e)
        {
            if (dgvPuntos.CurrentRow != null)
            {
                dgvPuntos.Rows.RemoveAt(dgvPuntos.CurrentRow.Index);
            }
        }

        private void btnQuitarTodos_Click(object sender, EventArgs e)
        {
            dgvPuntos.Rows.Clear();
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char) Keys.Back) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char) Keys.Back) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtY.Focus();
        }

        private void txtY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) AgregarParValores();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlterarDatos_Click(object sender, EventArgs e)
        {
            BloquearControles(false);
        }

        private void BloquearControles(bool bloquear = true)
        {
            btnAgregarPunto.Enabled = !bloquear;
            btnQuitarPunto.Enabled = !bloquear;
            btnQuitarTodos.Enabled = !bloquear;
            groupPolinomios.Enabled = !bloquear;

            btnPasosCalculos.Enabled = bloquear;
            btnEspecializarEnK.Enabled = bloquear;
            btnAlterarDatos.Enabled = bloquear;

            if (bloquear) txtPolinomio.Text = _pxString;
        }

        private void Procesar_Click(object sender, EventArgs e)
        {
            BloquearControles();

            //DEBEN ESTAR ORDENADOS LOS PUNTOS, SEGUN LAS Xi, PARA PODER SABER SI SON EQUIESPACIADAS
            dgvPuntos.Sort(dgvPuntos.Columns[0], System.ComponentModel.ListSortDirection.Ascending);

            _valores = new List<KeyValuePair<double, double>>();
            foreach (DataGridViewRow row in dgvPuntos.Rows)
            {
                _valores.Add(
                    new KeyValuePair<double, double>(
                        double.Parse(row.Cells["X"].Value.ToString()),
                        double.Parse(row.Cells["Y"].Value.ToString())
                    ));
            }

            if (opLagrange.Checked)
            {
                _lagrange = new Lagrange(_valores);
                txtPolinomio.Text = _lagrange.ObtenerPx();
            }
            else if (opNGProgre.Checked || opNGRegresiva.Checked)
            {
                _ng = new Ng(_valores);
                txtPolinomio.Text = _ng.ObtenerPx(opNGProgre.Checked, opNGRegresiva.Checked);
            }
        }

        private void btnPasosCalculos_Click(object sender, EventArgs e)
        {
            if (opLagrange.Checked)
            {
                if (_lagrange == null)
                {
                    MessageBox.Show("Debe procesar los valores primero", "Sin datos", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    var frmPasosDeCalculos = new FrmPasosDeCalculos(_lagrange.ObtenerPasos());
                    frmPasosDeCalculos.Show();
                }
            }
            else if (opNGProgre.Checked || opNGRegresiva.Checked)
            {
                if (_ng == null)
                {
                    MessageBox.Show("Debe procesar los valores primero", "Sin datos", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    _ng.ObtenerPasos(dgvPuntos);

                }
            }
        }

        private void btnEspecializarEnK_Click(object sender, EventArgs e)
        {
            var stringK = Interaction.InputBox("Ingre el valor de K: ", "Especializacion del polinomio");//, "0.0"); //,100,0);

            if (stringK != "")
            {
                var k = Convert.ToDouble(stringK);
                var pEnY = Convert.ToDouble(dgvPuntos.Rows[0].Cells[1].Value);
                var resultado = "";

                if (opNGProgre.Checked || opNGRegresiva.Checked)
                {
                    resultado = _ng.ObtenerPk(k, pEnY);
                }
                else if (opLagrange.Checked)
                {
                    resultado = _lagrange.ObtenerPk(k, pEnY);
                }

                MessageBox.Show("P(" + k + ") = " + resultado, "Valor de la Imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}