using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        public static void Main(string[] args)
        {
            string sourcePath = @"D:\Projetos C#\Arquivos\file1.txt"; //@ é para não digitar duas barras
            string targetPath = @"D:\Projetos C#\Arquivos\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                //copiar para outro arquivo
                fileInfo.CopyTo(targetPath);

                //ler as linhas do arquivo e guardar em uma varialvel
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}