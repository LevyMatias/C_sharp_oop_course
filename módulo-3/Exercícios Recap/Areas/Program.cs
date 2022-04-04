using System;
using System.Globalization;

namespace Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] valores = Console.ReadLine().Split(' ');
            float v1 = float.Parse(valores[0],CultureInfo.InvariantCulture);
            float v2 = float.Parse(valores[1],CultureInfo.InvariantCulture);
            float v3 = float.Parse(valores[2],CultureInfo.InvariantCulture);

            double areaTriangulo = (v1 * v3) / 2.0;
            double areaCirculo = Math.PI * v3 * v3;
            double areaTrapezio = (v1 + v2) * v3 / 2.0;
            double areaQuadrado = v2 * v2;
            double areaRetangulo = v1 * v2;

            Console.WriteLine("TRIANGULO = {0}",areaTriangulo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO = {0}",areaCirculo.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO = {0}",areaTrapezio.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO = {0}",areaQuadrado.ToString("F3",CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO = {0}",areaRetangulo.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
