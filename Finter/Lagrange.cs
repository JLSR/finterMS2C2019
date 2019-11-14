using System;
using System.Collections.Generic;
using System.Text;

namespace Finter
{
    public class Lagrange
    {
        private IReadOnlyList<KeyValuePair<double, double>> valores;
        private List<Polinomio> _polinomios;
        private List<List<double>> _px;
        private List<double> _pxFinal;

        public class Polinomio
        {
            public PolinomioPrimerPaso PrimerPaso;
            public PolinomioSegundoPaso SegundoPaso;

            public Polinomio(PolinomioPrimerPaso primerPaso, PolinomioSegundoPaso segundoPaso)
            {
                PrimerPaso = primerPaso;
                SegundoPaso = segundoPaso;
            }
        }

        public class PolinomioPrimerPaso
        {
            public string NumeradorString;
            public string DenominadorString;
        }
        
        public class PolinomioSegundoPaso
        {
            public List<double> Numerador = new List<double>();
        }

        public Lagrange(IReadOnlyList<KeyValuePair<double, double>> valoresParam)
        {
            valores = valoresParam;
            _polinomios = new List<Polinomio>();
            for (var i = 0; i < valores.Count; i++)
            {
                var primerPaso = new PolinomioPrimerPaso();
                var segundoPaso = new PolinomioSegundoPaso();
                
                var pivot = valores[i].Key;
                double denominador = 1;
                for (var j = 0; j < valores.Count; j++)
                {
                    var pivotSegundo = valores[j].Key;
                    if (j == i) continue;

                    var xMenosF = new List<double> {-pivotSegundo, 1};
                    primerPaso.NumeradorString += "(X - " + pivotSegundo + ") ";
                    primerPaso.DenominadorString += "(" + pivot + " - " + pivotSegundo + ") ";
                    segundoPaso.Numerador = MultiplicarPolinomios(segundoPaso.Numerador, xMenosF);
                    denominador *= pivot - pivotSegundo;
                }

                segundoPaso.Numerador = DistributivaDivision(segundoPaso.Numerador, denominador);

                _polinomios.Add(new Polinomio(primerPaso, segundoPaso));
            }
        }

        public string ObtenerPasos()
        {
            var retorno = "";
            for (var i = 0; i < _polinomios.Count; i++)
            {
                var polinomio = _polinomios[i];
                retorno += "L" + i + "(x) = " + polinomio.PrimerPaso.NumeradorString + "/ " + 
                           polinomio.PrimerPaso.DenominadorString + "= " +
                           ImprimirPolinomio(polinomio.SegundoPaso.Numerador) + Environment.NewLine + Environment.NewLine;
            }

            return retorno;
        }

        private string Subrayar(string palabra)
        {
            var ret = "";
            for (var i = 0; i < palabra.Length - 4; i++)
            {
                ret += "─";
            }

            return ret;
        }

        public string ObtenerPx()
        {
            _px = new List<List<double>>();

            for (var i = 0; i < _polinomios.Count; i++)
            {
                _px.Add(Distributiva(_polinomios[i].SegundoPaso.Numerador, valores[i].Value));
            }

            var xCant = 0;
            if (_px.Count > 0) xCant = _px[0].Count;
            _pxFinal = InitMatrizResult(xCant);
            for (var l = 0; l < _px.Count; l++)
            {
                for (var x = 0; x < xCant; x++)
                {
                    _pxFinal[x] += _px[l][x];
                }
            }

            return "P(X): " + ImprimirPolinomio(_pxFinal);
        }

        private List<double> InitMatrizResult(int xCant)
        {
            var ret = new List<double>();
            for (var i = 0; i < xCant; i++)
            {
                ret.Add(0);
            }

            return ret;
        }

        private List<double> DistributivaDivision(IEnumerable<double> polinomio, double producto)
        {
            return Distributiva(polinomio, producto, true);
        }
        
        private List<double> Distributiva(IEnumerable<double> polinomio, double numero, bool division = false)
        {
            var ret = new List<double>(polinomio);
            for (var i = 0; i < ret.Count; i++)
            {
                if (division)
                {
                    if (ret[i] != 0) ret[i] /= numero;
                }
                else
                {
                    ret[i] *= numero;
                }
            }

            return ret;
        }

        private double CalcularPolinomio(IReadOnlyList<double> polinomio, double k)
        {
            var ret = 0D;
            for (var i = 0; i < polinomio.Count; i++)
            {
                ret += Math.Pow(k, i) * polinomio[i];
            }

            return ret;
        }

        public string ObtenerPk(double k)
        {
            return CalcularPolinomio(_pxFinal, k).ToString();
        }

        private List<double> MultiplicarPolinomios(List<double> primerPol, List<double> segPol)
        {
            if (primerPol.Count == 0) return segPol;
            if (segPol.Count == 0) return primerPol;
            
            var a = primerPol.ToArray();
            var b = segPol.ToArray();
            var result = new double[a.Length + b.Length - 1];
            
            for (var i = 0; i < a.Length; i++)
            {
                for (var j = 0; j < b.Length; j++)
                {
                    result[i + j] += a[i] * b[j];
                }
            }
            return new List<double>(result);
        }

        private string ImprimirPolinomio(IReadOnlyList<double> polinomio)
        {
            var ret = new StringBuilder();
            var primero = polinomio.Count - 1;
            for (var i = primero; i >= 0; i--)
            {
                if (i != primero && polinomio[i] >= 0) ret.Append(" + ");
                if ((i != 0 && polinomio[i] != 1) || i == 0) ret.Append(Math.Round(polinomio[i], 2));
                if (i > 0) ret.Append("X");
                if (i > 1) ret.Append("^").Append(i.ToString());
            }

            return ret.ToString();
        }

        public string ObtenerGrado()
        {
            return (_pxFinal.Count - 1).ToString();
        }
    }
}