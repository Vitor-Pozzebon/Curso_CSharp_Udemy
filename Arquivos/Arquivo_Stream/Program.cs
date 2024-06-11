using System;
using System.IO;

namespace Arquivos_Stream
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"D:\Projetos C#\Arquivos\file1.txt"; //@ é para não digitar duas barras

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);  //OpenText instancia o StreamReader e já le o arquivo
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }                 
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}