using AreaCalculate.Entities.Abstract;

namespace AreaCalculate.Entities.Concrete
{
    public class Square : Shape
    {
        private int Side { get; set; }

        public Square(int side)
        {
            Side = side;
        }

        public override int Area()
        {
            return (int)Math.Pow(Side, 2);
        }

        public override int Perimeter()
        {
            return Side * 4;
        }

        public override int Volume()
        {
            return (int)Math.Pow(Side, 3);
        }
    }
}
