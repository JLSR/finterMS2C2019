using System;
using System.Collections.Generic;
using System.Text;

namespace Finter
{
    internal static class Util
    {
        /*
         * Escribir los términos del polinomio de menor grado a mayor
         * Ej: (x^2 + 2x -3) -->  { -3, 2, 1 }
         *     (x + 2) --> { 2, 1 }
         */
        public static List<double> MultiplicarPolinomios(List<double> a, List<double> b)
        {
            var result = new List<double>();
            for (var i = 0; i < a.Count; i++)
            {
                for (var j = 0; j < b.Count; j++)
                {
                    result[i + j] += a[i] * b[j];
                }
            }
            return result;
        }
        
        public static string MultiplicarTodosPolinomios(List<List<double>> polinomios)
        {
            var acum = polinomios[0];
            for (var i = 1; i < polinomios.Count - 1; i++)
            {
                acum = MultiplicarPolinomios(acum, polinomios[i]);
            }
            return PolinomioAString(acum);
        }

        private static string PolinomioAString(List<double> p)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < p.Count; i++)
            {
                if (i > 0) sb.Append(" + ");
                sb.Append(p[i].ToString());
                if (i > 0) sb.Append("x^").Append(i.ToString());
            }
            return sb.ToString();

        }

        public static string ImprimirPasos(List<Lagrange.Fraccion> polinomios)
        {
            var retorno = "";
            for (var i = 0; i < polinomios.Count; i++)
            {
                retorno += "L(" + i + ") = " + polinomios[i].NumeradorString + "  /  " + polinomios[i].DenominadorString + Environment.NewLine;
            }
            return ("Inicia interpolación Lagrange" + Environment.NewLine) + retorno + "Finalización interpolación Lagrange";
        }
    }
}
