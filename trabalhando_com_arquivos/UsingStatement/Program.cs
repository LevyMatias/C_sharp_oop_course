using System;
using System.IO;

namespace UsingStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\EstudosLevy\Dotnet Studies\c_sharp_courses\NotacaoXadrez.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
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

            // Exemplo2();
        }

        static void Exemplo2()
        {
            string path = @"C:\EstudosLevy\Dotnet Studies\c_sharp_courses\NotacaoXadrez.txt";
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
