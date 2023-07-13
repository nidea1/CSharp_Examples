using System.Collections;

class Program
{
    static void Main()
    {
        // Write a program that finds the largest 3 and the smallest 3 of the 20 numbers entered from the keyboard, calculates the averages of both groups and prints these averages and average totals to the console. (Write using the Array class.)
        int n = 20;
        ArrayList numbers = new ArrayList();
        ArrayList lowerNumbers = new ArrayList();
        ArrayList highestNumbers = new ArrayList();

        Console.WriteLine($"Enter {n} numbers");
        for (int i = 0; i < n;i++){
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        numbers.Sort();

        lowerNumbers = numbers.GetRange(0, 3);
        highestNumbers = numbers.GetRange(numbers.Count - 3, 3);

        int sumLowerNumbers = SumOfList(lowerNumbers);
        int sumHighestNumbers = SumOfList(highestNumbers);

        float avgLowerNumbers = AvgOfList(sumLowerNumbers, lowerNumbers.Count);
        float avgHighestNumbers = AvgOfList(sumHighestNumbers, highestNumbers.Count);
        float totalAvgs = avgLowerNumbers + avgHighestNumbers;

        Console.WriteLine($"Avg of Lowers: {avgLowerNumbers}\nAvg of Highestes: {avgHighestNumbers}\nTotal of Avgs: {totalAvgs}");
    }

    static int SumOfList(ArrayList numList)
    {
        int total = 0;
        foreach (int num in numList){
            total += num;
        }
        return total;
    }

    static float AvgOfList(int total, int divider)
    {
        return total/divider;
    }
}
