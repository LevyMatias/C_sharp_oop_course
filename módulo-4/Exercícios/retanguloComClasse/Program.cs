/* Fazer um programa para ler os valores da largura e altura de um retângulo. Em
seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
como mostrado no projeto ao lado. */
using System;
using System.Globalization;

namespace retanguloComClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r;
            r = new Retangulo();

	  Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area: "+r.Area().ToString("F2", CultureInfo.InvariantCulture));
	   Console.WriteLine("Perimetro = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
	  Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
