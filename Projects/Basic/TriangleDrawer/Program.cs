namespace TriangleDrawer
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                try{
                    Console.Write("Enter the Triangle Length: ");
                    int length = Convert.ToInt32(Console.ReadLine());
                    if (length == 0)
                    {
                        throw new Exception("You must enter a valid number.");
                    }

                    DrawTriangle(length);

                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        static void DrawTriangle(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                for (int j = 0; j < length - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
