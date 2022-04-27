using Interface_2.Models.Entities;
using Interface_2.Models.Enums;
using System;

namespace Interface_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = new Circle(3.00, ColorEnum.Black);
            var shape2 = new Rectangle(7.00,5.00, ColorEnum.Blue);
            Console.WriteLine(shape);
            Console.WriteLine(shape2);
        }
    }
}
