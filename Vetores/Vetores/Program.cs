using System;
using System.Globalization;

namespace Vetores {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite quantos elementos terá o vetor: ");
            int n = int.Parse(Console.ReadLine());

            //estrutura do vetor
            double[] vect = new double[n];

            for(int i = 0; i < n; i++) {
                Console.Write("Digite o valor do termo " + i + ": ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;

            for (int i = 0; i < n; i++) {
                soma += vect[i];
            }

            double avg = soma / n;

            Console.WriteLine("Altura média = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}