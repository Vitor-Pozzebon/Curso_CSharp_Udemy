using Interface_IComparable.Entities;
using System;

namespace Comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Projetos C#\Interfaces\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp  in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}