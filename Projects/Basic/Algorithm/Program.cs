namespace Algorithm
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a splitted text and number with (,) (Example,3): ");
                    string? text = Console.ReadLine();

                    if (text == null || text == "")
                    {
                        throw new Exception("You must enter a valid format!");
                    }

                    string[] arr = text.Trim().Split(',');

                    if (arr.Length == 1 || arr.Length > 2)
                    {
                        throw new Exception("You must enter a valid format!\nExample,3");
                    }

                    string newText = arr[0];
                    int textIndex = Convert.ToInt32(arr[1]);

                    newText = newText.Remove(textIndex, 1);

                    Console.WriteLine(newText);

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
