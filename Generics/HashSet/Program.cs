using System;
using System.Collections.Generic;

namespace set
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //união
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            Console.WriteLine("Union:");
            printCollection(c);

            //interseção
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            Console.WriteLine("Intersection:");
            printCollection(d);

            //diferença
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Console.WriteLine("Difference:");
            printCollection(e);
        }

        static void printCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}