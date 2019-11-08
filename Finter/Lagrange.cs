using System.Collections.Generic;

namespace Finter
{
    public class Lagrange
    {
        private List<Fraccion> polinomios;

        public struct Fraccion
        {
            public List<List<double>> Numerador;
            public string NumeradorString;
            public string NumeradorMultiplicado;
            public double Denominador;
            public string DenominadorString;
        }

        public Lagrange(List<KeyValuePair<double, double>> valores)
        {
            polinomios = new List<Fraccion>();
            for (var i = 0; i < valores.Count; i++)
            {
                var fraccion = new Fraccion {Numerador = new List<List<double>>()};
                var pivot = valores[i].Key;
                for (var j = 0; j < valores.Count; j++)
                {
                    var pivotSegundo = valores[j].Key;
                    if (j == i) continue;

                    fraccion.Numerador.Add(new List<double> {pivotSegundo, 1}); //El 1 representa la X
                    fraccion.NumeradorString += "(X - " + pivotSegundo + ") ";
                    fraccion.Denominador = pivot - pivotSegundo;
                    fraccion.DenominadorString += "(" + pivot + " - " + pivotSegundo + ") ";
                }

//                fraccion.NumeradorMultiplicado = Util.MultiplicarPolinomios(fraccion.Numerador);
                polinomios.Add(fraccion);
            }
        }

        public string ObtenerPasos()
        {
            return Util.ImprimirPasos(polinomios);
        }

        public string ObtenerPx()
        {
//            for (var i = 0; i < polinomios.Count; i++)
//            {
//                for (var j = 1; j < polinomios[i].Numerador.Count; j++)
//                {
//                    polinomios[i].Numerador[j] = Util.MultiplicarPolinomio(polinomios[i].Numerador[j], polinomios[i].Numerador[j+1]);;
//                }
//            }

            return "Pendiente";
        }
    }
}