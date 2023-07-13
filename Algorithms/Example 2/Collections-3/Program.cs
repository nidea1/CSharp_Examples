using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Write a program that stores the vowels in a sentence entered from the keyboard in an array and sorts the elements of the array.
        char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u'};

        Console.Write("Enter a clause: ");
        string clause = Console.ReadLine();

        List<char> vowelList = new List<char>();

        foreach (char c in clause)
        {
            if (vowels.Contains(char.ToLower(c)))
            {
                vowelList.Add(c);
            }
        }

        vowelList.Sort();

        Console.WriteLine("Vowels in the clause:");
        foreach (char v in vowelList)
        {
            Console.Write(v + " ");
        }
    }
}
