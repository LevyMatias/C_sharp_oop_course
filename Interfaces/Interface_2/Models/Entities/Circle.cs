using Interface_2.Models.Enums;
using System;
using System.Globalization;

namespace Interface_2.Models.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle(double radius,ColorEnum color): base(color)
        {
            Radius = radius;
        }

        public override double GetArea() => Math.PI * Radius * Radius;

        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                +", area = "
                + GetArea().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
