using System;
using System.Globalization;

namespace Vetores {
    class VetorDeProdutos {
        static void Main(string[] args) {

            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double soma = 0;
            for (int i = 0;i < n;i++) {
                soma += vect[i].Price;
            }

            double avg = soma / n;

            Console.WriteLine("Preço médio = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
