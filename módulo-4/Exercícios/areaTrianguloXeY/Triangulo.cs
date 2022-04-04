using System;

namespace areaTrianguloXeY
{
    public class Triangulo
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double Area()
        {
            double p = (A+B+C)/2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}