using System;
using System.Linq;
using System.Collections.Generic;
using ExercicioFixacao.Entities;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using(StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    
                    list.Add(new Employee(name, email, salary));
                }
            }

            //inserção da lógica do exercício
            Console.Write("Enter salary: ");
            double salaryLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //expressão linq com lambda para pegar os emails dos funcionários selecionados
            var emails = list.Where(p => p.Salary > salaryLimit).Select(p => p.Email).Order();

            //expressão linq com lambda para pegar a soma dos funcionários selecionados
            var sum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);

            //mostrando os resultados na tela
            foreach(string email in emails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine("Sum of salary of people whose name starts with 'M': " 
                + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}