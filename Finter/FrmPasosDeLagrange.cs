using System;
using System.Windows.Forms;

namespace Finter
{
    public partial class FrmPasosDeCalculos : Form
    {
        private readonly string _pasos;
        private readonly string _grado;
        private readonly string _equiespaciado;
        
        public FrmPasosDeCalculos(string pasosParam, string gradoParam, string equiespaciadoParam)
        {
            InitializeComponent();
            _pasos = pasosParam;
            _grado = gradoParam;
            _equiespaciado = equiespaciadoParam;
        }

        private void FrmPasosDeCalculos_Load(object sender, EventArgs e)
        {
            txtPasos.Text = _pasos;
            lblGrado.Text += _grado;
            lblEquiespaciado.Text += _equiespaciado;
        }
    }
}
