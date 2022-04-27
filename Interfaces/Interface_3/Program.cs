using Interface_3.Devices;
using System;

namespace Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("Csharp programming");
            p.ProcessDoc("Course");
            p.Print("Programming lenguage!");

            var s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("Levy.@eu.com");
            Console.WriteLine(s.Scan());
            Console.WriteLine();

            // with interface
            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("Studying Csharp!");
            c.Print("Learn everyday!");
            Console.WriteLine(c.Scan());
        }
    }
}
