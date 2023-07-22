namespace AvgCalculator
{
    class Program
    {
        static void Main()
        {

            while (true)
            {
                try{
                    Console.Write("Enter a depth level for fibonacci: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n >= 1)
                    {
                        var fibonacci = CreateFibonacci(n);
                        double avg = AvgCalculate(fibonacci);
                        Console.WriteLine("Your fibonacci series average: " + avg);
                        break;
                    }
                    else
                    {
                        throw new Exception("You must enter equal or bigger than 1!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

        }

        static List<long> CreateFibonacci(int n)
        {
            List<long> fibonacci = new();

            long a = 1, b = 1;

            if (n == 1)
            {
                fibonacci.Add(1);
                return fibonacci;
            }
            for (int i = 0; i < n; i++)
            {
                fibonacci.Add(a);
                a = b;
                b += fibonacci[i];
            }
            
            return fibonacci;
        }

        static double AvgCalculate(List<long> fibonacci)
        {
            double sum = 0;

            foreach (var num in fibonacci)
            {
                sum += num;
            }

            return sum / fibonacci.Count;
        }
    }
}
