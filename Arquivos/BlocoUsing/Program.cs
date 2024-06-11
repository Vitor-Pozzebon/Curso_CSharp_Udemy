using System;
using System.IO;

namespace Arquivos_Stream
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"D:\Projetos C#\Arquivos\file1.txt"; //@ é para não digitar duas barras

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
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