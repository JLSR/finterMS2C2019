using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Finter
{
    internal struct Elemento
    {
        public double A;
        public double B;
        public double C;
        public double D;
        public double R;
    }

    internal class Ng
    {
        List<List<Elemento>> listaDeListas = new List<List<Elemento>>();
        List<KeyValuePair<double, double>> valores;

        public Ng(List<KeyValuePair<double, double>> valParam)
        {
            valores = valParam;
            //List<ElementoLista> listaDeListas = new List<ElementoLista>();
            int i;
            //Form frmPasosDeCalculosNG1 = new frmPasosDeCalculosNG();

            listaDeListas.Clear();

            for (i = 0; i < valores.Count - 1; i++)
            {
                var unaLista = new List<Elemento>();
                listaDeListas.Add(unaLista);
            }
            //txtRowC.Text = dgvPuntos.RowCount.ToString();

            for (i = 1; i < valores.Count; i++)
            {
                var unElemento = new Elemento();
                unElemento.A = Convert.ToDouble(valores[i].Value);
                unElemento.B = Convert.ToDouble(valores[i - 1].Value);
                unElemento.C = Convert.ToDouble(valores[i].Key);
                unElemento.D = Convert.ToDouble(valores[i - 1].Key);
                unElemento.R = (unElemento.A - unElemento.B) / (unElemento.C - unElemento.D);

                listaDeListas[0].Add(unElemento);
                //unaLista.Elementos.Add(unElemento);
            }

            int j;
            for (i = 0; i < listaDeListas.Count - 1; i++)
            {
                for (j = 1; j < listaDeListas[i].Count; j++)
                {
                    Elemento unElemento = new Elemento();

                    unElemento.A = listaDeListas[i][j].R;
                    unElemento.B = listaDeListas[i][j - 1].R;
                    unElemento.C = listaDeListas[i][j].C;
                    unElemento.D = listaDeListas[i][j - 1].D;
                    unElemento.R = (unElemento.A - unElemento.B) / (unElemento.C - unElemento.D);

                    listaDeListas[i + 1].Add(unElemento);
                }
            }
        }

        public void ObtenerPasos()
        {
            var frmPasosDeCalculosNg = new FrmPasosDeCalculosNG();
            frmPasosDeCalculosNg.Show();

            int i;
            int j;

            frmPasosDeCalculosNg.txtCountLdL.Text = listaDeListas.Count.ToString();

            for (i = 0; i < listaDeListas.Count; i++)
            {
                DataGridViewTextBoxColumn unaColumna = new DataGridViewTextBoxColumn();
                unaColumna.HeaderText = (i + 1).ToString(); // +1;
                unaColumna.Width = 100;

                frmPasosDeCalculosNg.dgvPasos.Columns.Add(unaColumna);
            }

            //for (i = 0; i < listaDeListas.Count;i++)
            //{
            //frmPasosDeCalculosNG1.dgvPasos.Rows.Add(listaDeListas[0]
            //}

            for (i = 0; i < listaDeListas[0].Count; i++)
            {
                frmPasosDeCalculosNg.dgvPasos.Rows.Add(listaDeListas[0][i].R);
            }

            for (i = 1; i < listaDeListas[0].Count; i++)
            {
                for (j = 0; j < listaDeListas[i].Count; j++)
                {
                    frmPasosDeCalculosNg.dgvPasos.Rows[j].Cells[i].Value = listaDeListas[i][j].R;
                }
            }
        }

        public string ObtenerPx(bool rbNgPro = false, bool rbNgReg = false)
        {
            if (rbNgPro) //POLINOMIO INTERPOLANTE PROG PARA MOSTRAR
            {
                var p = "P(X): " + valores[0].Value;

                for (var i = 0; i < listaDeListas.Count; i++)
                {
                    var aux = "";

                    for (var j = 0; j <= i; j++)
                    {
                        aux += "(X-" + valores[j].Key + ")";
                    }

                    p += "+" + listaDeListas[i][0].R + aux;
                }

                return p;
            }

            if (rbNgReg) //POLINOMIO INTERPOLANTE REGRE PARA MOSTRAR
            {
                var p = "P(X): " + valores[valores.Count - 1].Value;

                for (var i = 0; i < listaDeListas.Count; i++)
                {
                    var aux = "";

                    for (var j = valores.Count - 1; j >= valores.Count - 1 - i; j--)
                    {
                        aux += "(X-" + valores[j].Key + ")";
                    }

                    p += "+" + listaDeListas[i][listaDeListas[i].Count - 1].R + aux;
                }

                return p;
            }

            return "";
        }

        public string ObtenerPk(double k, double pEnY)
        {
            int i, j;

            // MessageBox.Show("pEnY: " + pEnY.ToString(), "Valor de la Imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);

            for (i = 0; i < listaDeListas.Count; i++)
            {
                var aux = 1.0;

                for (j = 0; j <= i; j++)
                {
                    //aux *= Convert.ToDouble(K) - Convert.ToDouble(dgvPuntos.Rows[j].Cells[0].Value);
                    aux *= k - Convert.ToDouble(valores[j].Key);
                    //MessageBox.Show("aux: " + aux.ToString(), "Valor de la Imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                pEnY += listaDeListas[i][0].R * aux;
                //MessageBox.Show("pEnY: " + pEnY.ToString(), "Valor de la Imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return pEnY.ToString();
        }
    }
}