using System;
using System.Linq;

namespace Introducao_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // especificar o data source
            int[] numbers = new int[] { 2,3,4,5 };

            //definir a expressão de consulta
            //x tal que x seja par e multiplicar esse número por 10
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // executar a consulta
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}