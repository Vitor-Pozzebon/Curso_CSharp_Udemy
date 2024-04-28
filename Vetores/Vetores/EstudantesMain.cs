using System;
using System.Globalization;
using System.Numerics;

namespace Vetores {
    class EstudantesMain {
        static void Main(string[] args) {
            Console.Write("Digite quantos quartos serão alocados: ");
            int n = int.Parse(Console.ReadLine());

            Estudantes[] rent = new Estudantes[10];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("\nRent #" + (i + 1));
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());

                rent[room] = new Estudantes(name, email);
            }

            Console.WriteLine("Busy Rooms: ");
            for (int i = 0; i < 10; i++) {
                if(rent[i] != null) {
                    Console.WriteLine(i + ": " + rent[i]);
                }
            }
        }
    }
}
