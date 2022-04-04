using System;
using System.Globalization;

namespace retanguloComClasse
{
    public class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Altura + Largura) * 2;
        }

        public double Diagonal()
        {
            double d = (Math.Pow(Altura, 2)) + (Math.Pow(Largura, 2));
            return Math.Sqrt(d);
        }

        public override string ToString()
        {
            return Area()
            + ", Perimetro: "
            + Perimetro()
            + ", Diagonal: "
            + Diagonal().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}