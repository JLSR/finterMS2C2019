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
    public partial class FrmLagrange : Form
    {
        public FrmLagrange(List<KeyValuePair<double, double>> valores)
        {
            InitializeComponent();
            txtFuncion.Text = Interpolar(valores, 0).ToString();
        }

        double Interpolar(List<KeyValuePair<double, double>> valores, double xi)
        {
            txtPasos.Text = "Inicia interpolación Lagrange" + Environment.NewLine;

            double result = 0;
            for (int i = 0; i < valores.Count; i++)
            {
                double termino = valores[i].Value;
                for (int j = 0; j < valores.Count; j++)
                {
                    if (j != i)
                        txtPasos.AppendText(termino + " * (" + xi + " - " + valores[j].Key + ") / (" + valores[i].Key + " - " + valores[j].Value + ")" + Environment.NewLine);
                        termino = termino * (xi - valores[j].Key) / (valores[i].Key - valores[j].Value);
                }

                result += termino;
            }

            txtPasos.AppendText("Finalización interpolación Lagrange");

            return result;
        }

        private void chkPasos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPasos.Checked)
            {
                this.Size = new Size(578, 443);
            }
            else
            {
                this.Size = new Size(578, 97);
            }
        }

        private void FrmLagrange_Load(object sender, EventArgs e)
        {
            this.Size = new Size(578, 97);
        }
    }
}
