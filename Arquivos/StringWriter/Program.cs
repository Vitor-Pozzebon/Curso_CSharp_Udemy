using System;

namespace StringWriter
{
    class Program
    {
        public static void Main(string[] args)
        {
            string sourcePath = @"D:\Projetos C#\Arquivos\file1.txt";
            string targetPath = @"D:\Projetos C#\Arquivos\file2.txt";

            try
            {
                //ler o conteudo do arquivo
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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