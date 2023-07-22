﻿namespace ReverseChar
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a text: ");
                    string? text = Console.ReadLine();

                    if (text == null || text == "")
                    {
                        throw new Exception("You must enter a text!");
                    }

                    string[] arr = Reverser(text);



                    foreach (var item in arr)
                    {
                        Console.Write(item + " ");
                    }

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        static string[] Reverser(string text)
        {
            string[] arr = text.Split();

            for (int i = 0; i < arr.Length; i++)
            {
                char first = arr[i][0];

                string newText = arr[i].Substring(1, arr[i].Length - 1) + first;

                arr[i] = newText;
            }

            return arr;
        }
    }
}
