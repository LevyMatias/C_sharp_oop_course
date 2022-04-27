

using Interface_2.Models.Enums;

namespace Interface_2.Models.Entities
{
    abstract class AbstractShape : IShape
    {
        public ColorEnum Color { get; set; }

        protected AbstractShape(ColorEnum color)
        {
            Color = color;
        }

        public abstract double GetArea();
    }
}
