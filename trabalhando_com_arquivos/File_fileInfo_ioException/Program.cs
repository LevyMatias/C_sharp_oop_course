using System;
using System.IO;

namespace File_fileInfo_ioException
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\EstudosLevy\Dotnet Studies\c_sharp_courses\NotacaoXadrez.txt";
            string targetPath = @"C:\EstudosLevy\Dotnet Studies\c_sharp_courses\NotacaoXadrez2.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
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

