using AreaCalculate.Entities.Abstract;

namespace AreaCalculate.Entities.Concrete
{
    public class Triangle : Shape
    {
        private int Side { get; set; }
        private int Height { get; set; }

        public Triangle(int side, int height)
        {
            Side = side;
            Height = height;
        }

        public override int Area()
        {
            return Side * Height / 2;
        }

        public override int Perimeter()
        {
            return Side * 3;
        }

        public override int Volume()
        {
            throw new InvalidOperationException("A triangle does not have a volume.");
        }
    }
}
