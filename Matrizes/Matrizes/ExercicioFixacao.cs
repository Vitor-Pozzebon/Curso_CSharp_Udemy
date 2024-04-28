using System;
using System.Globalization;

namespace Matrizes
{
    class ExercicioFixacao
    {
        static void Main(string[] args)
        {
            Console.Write("Digite os valores para m e n: ");
            string[] matrix = Console.ReadLine().Split(' ');
            int m = int.Parse(matrix[0]);
            int n = int.Parse(matrix[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("---------------------------------");
            Console.Write("Digite o valor que deseja procurar: ");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == v)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[(i - 1), j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, (j + 1)]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[(i + 1), j]);
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                    }
                }
            }

        }
    }
}
