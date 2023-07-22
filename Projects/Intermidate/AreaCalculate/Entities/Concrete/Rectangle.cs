using System;
using System.Dynamic;
using AreaCalculate.Entities.Abstract;

namespace AreaCalculate.Entities.Concrete
{
    public class Rectangle : Shape
    {
        private int Width { get; set; }
        private int Height { get; set; }
        private int Length { get; set; }

        public Rectangle(int width, int height, int length)
        {
            Width = width;
            Height = height;
            Length = length;
        }

        public override int Area()
        {
            return Width * Length;
        }

        public override int Perimeter()
        {
            return (Width + Length) * 2;
        }

        public override int Volume()
        {
            return Length * Width * Height;
        }
    }
}
