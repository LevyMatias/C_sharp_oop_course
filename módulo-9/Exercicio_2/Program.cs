/* Fazer um programa para ler os dados de N figuras (N fornecido
pelo usuário), e depois mostrar as áreas destas figuras na
mesma ordem em que foram digitadas. */
using Exercicio_2.Entities;
using Exercicio_2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using static System.Console;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Write("Enter the number of shapes: ");
            int n = int.Parse(ReadLine());

            for (int i = 1; i <= n; i++)
            {
                WriteLine($"Shape #{i} data: ");

                Write("Rectangle or Circle (r/c)? ");
                char resp = char.Parse(ReadLine());
                WriteLine();

                Write("Color (Black/Blue/Red): ");
                ColorEnum cor = Enum.Parse<ColorEnum>(ReadLine());
                WriteLine();

                if (resp == 'r')
                {
                    Write("Width: ");
                    double w = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                    WriteLine();

                    Write("Height: ");
                    double h = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                    WriteLine();

                    shapes.Add(new Rectangle(w,h,cor));
                }
                else
                {
                    Write("Radius: ");
                    double rad = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                    WriteLine();

                    shapes.Add(new Circle(rad, cor));
                }
            }

            WriteLine("Result Shapes: ");
            foreach (var shape in shapes)
            {
                WriteLine(shape.Value());
            }
        }
    }
}
