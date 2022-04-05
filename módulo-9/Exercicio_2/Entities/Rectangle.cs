using Exercicio_2.Entities.Enums;
using System.Globalization;

namespace Exercicio_2.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height,ColorEnum colorEnum) 
            : base(colorEnum)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea() => Width * Height;

        public override string Value()
        {
            return "Rectangle area: "
                + GetArea().ToString("F2", CultureInfo.InvariantCulture)
                + "\nColor: " + Color;
        }
    }
}
