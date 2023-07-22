namespace Consonants
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

                    CheckConsonants(text);

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        static void CheckConsonants(string text)
        {
            string[] arr = text.Split();

            string consonants = "bcçdfghjklmnpqrstsvxzyBCÇDFGHJKLMNPQRSTSVXZY";

            bool isDualContonants = false;

            foreach (string word in arr)
            {
                isDualContonants = false;
                for (int i = 0; i < word.Length - 1; i++)
                {
                    if (consonants.Contains(word[i]) && consonants.Contains(word[i + 1]))
                    {
                        isDualContonants = true;
                        break;
                    }
                }
                Console.WriteLine(isDualContonants);
            }
        }
    }
}
