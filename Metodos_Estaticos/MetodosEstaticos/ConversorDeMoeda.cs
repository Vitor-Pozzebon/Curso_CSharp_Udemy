using System;
using System.Globalization;

namespace MetodosEstaticos {
    class ConversorDeMoeda {
        public static double iof = 0.06;

        public static double Calculadora(double v, double d) {
            double valorFinal = v * d;

            return valorFinal + (valorFinal * iof);
        }
    }
}
