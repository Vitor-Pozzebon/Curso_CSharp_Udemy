using Generics;
using System;

namespace generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            //impressão do vetor
            printService.Print();

            //impressão do primeiro elemento do vetor
            Console.WriteLine("\nFirst: " + printService.First());
        }
    }
}