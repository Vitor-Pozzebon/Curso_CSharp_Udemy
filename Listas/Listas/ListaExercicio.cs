using System;
using System.Globalization;
using System.Collections.Generic;

namespace Listas {
    class ListaExercicio {
        static void Main(string[] args) {
            
            List<Funcionario> list = new List<Funcionario>();

            Console.Write("Digite quantos funcionários serão registrados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("\nFuncionario #" + (i+1));
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, name, salary));
            }

            Console.WriteLine("--------------------------------------");
            foreach (Funcionario funcionario in list) {
                Console.WriteLine(funcionario);
            }

            Console.Write("\nDigite o ID do funcionário que irá receber aumento de salário: ");
            int idIncrease = int.Parse(Console.ReadLine());
            
            Funcionario f = list.Find(x => x.Id == idIncrease);

            if(f != null) {
                Console.Write("Entre com a porcentagem: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                f.IncreaseSalary(percent);
            }
            else {
                Console.WriteLine("Esse ID não existe na lista!");
            }
            

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\nDados atualizados dos funcionários: ");
            foreach (Funcionario funcionario in list) {
                Console.WriteLine(funcionario);
            }
        }
    }
}
