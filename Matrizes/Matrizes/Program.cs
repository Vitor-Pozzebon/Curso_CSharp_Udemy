using System;
using System.Globalization;

namespace Matrizes {
    class Program {
        static void Main(string[] args) {

            //inicialização /instanciação de uma matriz
            double[,] mat = new double[2, 3];

            //propriedades

            Console.WriteLine(mat.Length);      //mostra o total de elementos da matriz
            Console.WriteLine(mat.Rank);        //mostra o primeiro termo da declaração da matriz (numero de linhas)
            Console.WriteLine(mat.GetLength(0));//mostra a quantidade de linhas
            Console.WriteLine(mat.GetLength(1));//mostra a quantidade de colunas
        }
    }
}