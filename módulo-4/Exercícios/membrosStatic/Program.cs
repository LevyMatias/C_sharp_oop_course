/* Fazer um programa para ler um valor numérico qualquer, e daí mostrar
quanto seria o valor de uma circunferência e do volume de uma esfera
para um raio daquele valor. Informar também o valor de PI com duas
casas decimais.*/

using System;
using System.Globalization;

namespace membrosStatic
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

            // versao 2

            Calculadora calc = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            
            double raio2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ2 = calc.Circunferencia(raio2);
            double volume2 = calc.Volume(raio2);

            Console.WriteLine("Circunferência: " + circ2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));

            // versao 3 

            // Console.Write("Entre o valor do raio: ");

            // Membros podem ser chamados sem ser instanciados
            
            // double raio2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // double circ2 = Calculadora.Circunferencia(raio2);
            // double volume2 = Calculadora.Volume(raio2);

            // Console.WriteLine("Circunferência: " + circ2.ToString("F2", CultureInfo.InvariantCulture));
            // Console.WriteLine("Volume: " + volume2.ToString("F2", CultureInfo.InvariantCulture));
            // Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
