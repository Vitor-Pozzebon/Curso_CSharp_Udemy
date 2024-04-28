using System;
using System.Drawing;
using System.Globalization;

namespace TipoDeDados {
    class Program {
        static void Main(string[] args) {
            
            Point p = new Point();
            Console.WriteLine(p);

             double? x = null;   //Nullable<double> x = null; é a mesma coisa
             double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if(x.HasValue) {
                Console.WriteLine(x.Value);
            }
            else {
                Console.WriteLine("X is null");
            }

            if(y.HasValue) {
                Console.WriteLine(y.Value);
            }
            else {
                Console.WriteLine("Y is null");
            }

            Console.WriteLine("-------------------");

            double? c = null;
            double? v = 10;

            double a = c ?? 5;
            double b = v ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
