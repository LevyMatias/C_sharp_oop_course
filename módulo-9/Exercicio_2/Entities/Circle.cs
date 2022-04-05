using Exercicio_2.Entities.Enums;
using System;
using System.Globalization;

namespace Exercicio_2.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, ColorEnum colorEnum)
            : base (colorEnum)
        {
            Radius = radius;
        }

        public override double GetArea() => Math.PI * Radius * Radius;

        public override string Value()
        {
            return "Circle area: " 
                + GetArea().ToString("F2", CultureInfo.InvariantCulture)
                + "\nColor: " + Color;
        }
    }
}
