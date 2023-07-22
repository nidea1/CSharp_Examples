namespace CircleDrawer
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                try{
                    Console.Write("Enter the Circle r: ");
                    int r = Convert.ToInt32(Console.ReadLine());
                    int radius = 2 * r;
                    if (radius == 0)
                    {
                        throw new Exception("You must enter a valid number.");
                    }

                    DrawCircle(radius);

                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        static void DrawCircle(int radius)
        {
            double dist;
      
            for (int i = 0; i <= 2 * radius; i++) {
                for (int j = 0; j <= 2 * radius; j++) {
                    dist = Math.Sqrt((i - radius) * 
                            (i - radius) + (j - radius) 
                                        * (j - radius));

                    if (dist > radius - 0.5 && dist < radius + 0.5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
            
                Console.WriteLine("");
            }
        }
    }
}
