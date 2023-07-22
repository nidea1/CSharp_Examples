using AreaCalculate.Entities.Abstract;
using AreaCalculate.Entities.Concrete;

namespace AreaCalculate
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please select a shape");
                Console.Write("(1) Rectangle\n(2) Square\n(3) Triangle\n(4) Exit\n");
                string? shape = Console.ReadLine();

                switch (shape)
                {
                    case "1":
                        Shape rectangle = RectangleCreator();
                        CalculatorMenu(rectangle);
                        break;
                    case "2":
                        Shape square = SquareCreator();
                        CalculatorMenu(square);
                        break;
                    case "3":
                        Shape triangle = TriangleCreator();
                        CalculatorMenu(triangle);
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please select a valid shape!");
                        break;
                }
            }
        }

        static Shape RectangleCreator()
        {
            Console.Write("Width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Shape rectangle = new Rectangle(width, height, length);

            return rectangle;
        }

        static Shape SquareCreator()
        {
            Console.Write("Side: ");
            int side = Convert.ToInt32(Console.ReadLine());

            Shape square = new Square(side);

            return square;
        }

        static Shape TriangleCreator()
        {
            Console.Write("Side: ");
            int side = Convert.ToInt32(Console.ReadLine());

            Console.Write("Height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Shape triangle = new Triangle(side, height);

            return triangle;
        }
    
        static void CalculatorMenu(Shape shape)
        {
            while (true)
            {
                Console.WriteLine("What do you calculate?");
                Console.Write("(1) Area\n(2) Perimeter\n(3) Volume\n(4) Upper Menu\n");
                string? option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AreaCalculator(shape);
                        break;
                    case "2":
                        PerimeterCalculator(shape);
                        break;
                    case "3":
                        VolumeCalculator(shape);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Select a valid option!");
                        break;
                }
            }
        }

        static void AreaCalculator(Shape shape)
        {
            int area = shape.Area();

            Console.WriteLine("Area: " + area);
        }

        static void PerimeterCalculator(Shape shape)
        {
            int perimeter = shape.Perimeter();

            Console.WriteLine("Perimeter: " + perimeter);
        }

        static void VolumeCalculator(Shape shape)
        {
            int volume = shape.Volume();

            Console.WriteLine("Volume: " + volume);
        }

    }
}
