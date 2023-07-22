using System;

namespace SumOfInts
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("How many will you enter dual number: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    int[] firstArr = new int[n];
                    int[] secondArr = new int[n];


                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Enter dual number (3 5): ");
                        string? numbers = Console.ReadLine() ?? throw new Exception("Please enter a valid format!\n3 5");

                        string[] numArr = numbers.Split();

                        if (numArr.Length != 2)
                        {
                            throw new Exception("Please enter a valid format!\n3 5");
                        }

                        firstArr[i] = Convert.ToInt32(numArr[0]);
                        secondArr[i] = Convert.ToInt32(numArr[1]);
                    }

                    for (int i = 0; i < n; i++)
                    {
                        if (firstArr[i] == secondArr[i])
                        {
                            Console.WriteLine(Math.Pow(firstArr[i] + secondArr[i], 2));
                        }
                        else
                        {
                            Console.WriteLine(firstArr[i] + secondArr[i]);
                        }
                    }

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
