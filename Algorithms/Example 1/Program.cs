using System;

class Program
{
    static void Main(string[] args)
    {
        // 1 - In a console application, ask the user to enter a positive number(n). Then ask the user to enter n positive numbers. Print the even numbers that the user has entered to the console.
        Console.Write("Enter a possitive number: ");
        int n = int.Parse(Console.ReadLine());
        int[] numberList = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter {0}st possitive number: ", i+1);
            int j = int.Parse(Console.ReadLine());
            numberList[i] = j;
        }

        foreach(int number in numberList){
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
            }
        }


        // 2 - In a console application, ask the user to enter two positive numbers (n, m). Then ask the user to enter n positive numbers. From the numbers entered by the user, print the numbers that are divisible by m to the console.
        Console.Write("Enter two possitive number: ");
        string[] numbs = Console.ReadLine().Trim().Split(" ");
        int n = int.Parse(numbs[0]);
        int m = int.Parse(numbs[1]);

        int[] numberList = new int[n];

        for (int i = 0; i < n; i ++)
        {
            Console.Write("Enter {0}st possitive number: ", i+1);
            int j = int.Parse(Console.ReadLine());
            numberList[i] = j;
        }

        foreach(int number in numberList){
            if (number % m == 0 || number == m)
            {
                Console.WriteLine(number);
            }
        }


        // 3 - In a console application, ask the user to enter a positive number (n). Then ask the user to enter n words. Print the words entered by the user from the end to the beginning to the console.
        Console.Write("Enter a possitive number: ");
        int n = int.Parse(Console.ReadLine());

        string[] wordList = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter {0}st word: ", i+1);
            string j = Console.ReadLine();
            wordList[i] = j;
        }

        Array.Reverse(wordList);

        foreach (string word in wordList){
            Console.WriteLine(word);
        }


        // 4 - In a console application, ask the user to type a sentence. Print the total number of words and letters in the sentence to the console.
        Console.Write("Enter a clause: ");
        string clause = Console.ReadLine();

        int totalWord = clause.Split().Count();
        int totalChar = clause.Length;

        Console.WriteLine("Word count in your clause: {0}", totalWord);
        Console.WriteLine("Char count in your clause: {0}", totalChar);
    }
}
