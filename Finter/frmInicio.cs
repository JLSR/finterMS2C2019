using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finter
{
    public partial class FrmInicio : Form
    {
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
                    Double x = Double.Parse(txtX.Text);
                    Double y = Double.Parse(txtY.Text);

                    dgvPuntos.Rows.Add(x, y);

                    txtX.Clear();
                    txtY.Clear();
                    txtX.Focus();
                }
                else
                {
                    MessageBox.Show("La Coordenada Y no puede tomar por valor el cero.", "Valor no permitido en coordenada Y", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Coordenada X o Coordenada Y vacía. Inserte ambos valores de las coordenadas.", "Coordenadas vacías", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPasosCalculos_Click(object sender, EventArgs e)
        {

        }

        private void btnEspecializarEnK_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarDatos_Click(object sender, EventArgs e)
            {
                // (x^2 + 2x -3)
                var a = new double[] { -3, 2, 1 };
                // (x+2)
                var b = new double[] { 2, 1 };

                var m = Multiply(a, b);
                Console.WriteLine(PolinomyToString(m));

            }


            static double[] Multiply(double[] a, double[] b)
            {
                var result = new double[a.Length + b.Length - 1];
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        result[i + j] += a[i] * b[j];
                    }
                }
                return result;
            }

            static string PolinomyToString(double[] p)
            {
                var sb = new StringBuilder();
                for (int i = 0; i < p.Length; i++)
                {
                    if (i > 0) sb.Append(" + ");
                    sb.Append(p[i].ToString());
                    if (i > 0) sb.Append("x^").Append(i.ToString());
                }
                return sb.ToString();

            }

        private void btnFinIngreso_Click(object sender, EventArgs e)
        {

        }

        private void Procesar_Click(object sender, EventArgs e)
        {
            if (opLagrange.Checked)
            {
                List<KeyValuePair<double, double>> valores = new List<KeyValuePair<double, double>>();
                foreach (DataGridViewRow row in dgvPuntos.Rows)
                {
                    valores.Add(
                        new KeyValuePair<double, double>(
                            Double.Parse(row.Cells["X"].Value.ToString()),
                            Double.Parse(row.Cells["Y"].Value.ToString())
                        ));
                }

                FrmLagrange form = new FrmLagrange(valores);
                form.Show();
            }
            else if (opNGProgre.Checked)
            {
                FrmNewtonGregory form = new FrmNewtonGregory();
                form.Show();
            }
            else if (opNGRegresiva.Checked)
            {
                FrmNewtonGregory form = new FrmNewtonGregory();
                form.Show();
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

        private void txtY_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
