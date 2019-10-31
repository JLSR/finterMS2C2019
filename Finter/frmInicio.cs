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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnAgregarPunto_Click(object sender, EventArgs e)
        {
            if(txtX.Text !="" && txtY.Text !="")
            {
                if (Double.Parse(txtY.Text) != 0)
                {
                    Double x = Double.Parse(txtX.Text);
                    Double y = Double.Parse(txtY.Text);
                        
                    dgvPuntos.Rows.Add(x, y);
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
            dgvPuntos.Rows.RemoveAt(dgvPuntos.CurrentRow.Index);
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
    }
}
