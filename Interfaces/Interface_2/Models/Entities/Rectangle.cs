using Interface_2.Models.Enums;
using System.Globalization;

namespace Interface_2.Models.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height,ColorEnum color): base(color)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea() => Width * Height;

        public override string ToString()
        {
            return "Rectangle color = "
                + Color
                + ", width = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                +", area = "
                + GetArea().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
