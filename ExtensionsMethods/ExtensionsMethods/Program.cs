using System;

namespace extension
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime dt = new DateTime(2024, 06, 18, 10, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}