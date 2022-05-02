using System;
using gethashcode_equals.Entities;

namespace gethashcode_equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client() { Name = "Jose", Email = "jose.email@eu.com" };
            Client c2 = new Client() { Name = "Julia", Email = "julia.email@eu.com" };

            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine(c2 == c1);
            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
        }
    }
}
