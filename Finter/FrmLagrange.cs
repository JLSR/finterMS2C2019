using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Finter
{
    public partial class FrmLagrange : Form
    {
        List<KeyValuePair<double, double>> valores;

        public FrmLagrange(List<KeyValuePair<double, double>> valParam)
        {
            InitializeComponent();
            valores = valParam;
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
//            this.Size = new Size(578, 97);
            this.Size = new Size(578, 443); //TODO Esto es solo para pruebas
            
            var lagrange = new Lagrange(valores);
            txtFuncion.Text = lagrange.ObtenerPx();
            txtPasos.Text = lagrange.ObtenerPasos();
        }
    }
}