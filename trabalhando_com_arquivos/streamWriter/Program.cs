using System;
using System.IO;

namespace streamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\EstudosLevy\Dotnet Studies\c_sharp_courses\NotacaoXadrez.txt";
            string targetPath = @"C:\EstudosLevy\Dotnet Studies\c_sharp_courses\NotacaoXadrez2.txt";
            try
            {
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
