// Aula sobre DateTime e definicoes
using System;
using System.Globalization;

namespace DateTimeExemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Construtores
            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Today;
            
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);


            // DateTime.Parse
            DateTime c1 = DateTime.Parse("2000-08-15");
            DateTime c2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime c3 = DateTime.Parse("15/08/2000");
            DateTime c4 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);


            // Parse.Exact
            DateTime c5 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
            CultureInfo.InvariantCulture);

            DateTime c6 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}
