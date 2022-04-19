using System;
using System.IO;

namespace Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\EstudosLevy\Informática";
            try
            {
                // listar as pastas a partir de uma pasta informada
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                // listar os arquivos a partir de uma pasta informada
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                // criando nova pasta
                Directory.CreateDirectory(path + @"\newfolder1");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
