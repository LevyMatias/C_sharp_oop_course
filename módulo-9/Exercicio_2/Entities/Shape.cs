using Exercicio_2.Entities.Enums;

namespace Exercicio_2.Entities
{
    abstract class Shape
    {
        public ColorEnum Color { get; set; }

        protected Shape(ColorEnum color)
        {
            Color = color;
        }

        public abstract double GetArea();

        public abstract string Value();
    }
}
