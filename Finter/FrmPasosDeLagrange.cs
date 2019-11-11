using System;
using System.Windows.Forms;

namespace Finter
{
    public partial class FrmPasosDeCalculos : Form
    {
        private readonly string _pasos;
        
        public FrmPasosDeCalculos(string pasosParam)
        {
            InitializeComponent();
            _pasos = pasosParam;
        }

        private void FrmPasosDeCalculos_Load(object sender, EventArgs e)
        {
            txtPasos.Text = _pasos;
        }
    }
}
