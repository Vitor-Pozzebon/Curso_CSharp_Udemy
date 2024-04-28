using System;
using System.Globalization;

namespace MetodosEstaticos {
    class Exercicio1 {
        static void Main(string[] args) {
            Console.Write("Qual a cotação do dólar?: ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar?: ");
            double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.Calculadora(compra, dolar);
            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
