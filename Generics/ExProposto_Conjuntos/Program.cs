using System;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n1; i++) 
            {
                int cod = int.Parse(Console.ReadLine());
                a.Add(cod);
            }

            Console.Write("How many students for course B? ");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n2; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                b.Add(cod);
            }

            Console.Write("How many students for course C? ");
            int n3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n3; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                c.Add(cod);
            }

            HashSet<int> all = new HashSet<int>(a);
            all.UnionWith(b);
            all.UnionWith(c);
            Console.WriteLine("Total Students: " + all.Count);
        }
    }
}