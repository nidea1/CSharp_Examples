using IronBarCode;

namespace BarcodeApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Barcode Application!");
            Console.WriteLine("1: Generate Barcode");
            Console.WriteLine("2: Read Barcode");
            Console.WriteLine("3: Exit");
            Console.Write("Make your choice: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GenerateBarcode();
                    break;

                case "2":
                    ReadBarcode();
                    break;

                case "3":
                    Environment.Exit(0);
                    break;
                
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        private static void GenerateBarcode()
        {
            Console.WriteLine("Enter the text for the barcode:");
            string userInput = Console.ReadLine();

            Console.WriteLine("Enter the full path where you want to save the barcode (e.g., C:\\Folder\\barcode.png):");
            string filePath = Console.ReadLine();

            BarcodeWriter.CreateBarcode(userInput, BarcodeWriterEncoding.Code128).SaveAsPng(filePath);

            Console.WriteLine($"Barcode saved as '{filePath}'.");
        }

        private static void ReadBarcode()
        {
            Console.WriteLine("Enter the full path of the barcode you want to read (e.g., C:\\Folder\\barcode.png):");
            string filePath = Console.ReadLine();

            BarcodeResult result = BarcodeReader.QuicklyReadOneBarcode(filePath);
            if (result != null)
            {
                Console.WriteLine($"Barcode content: {result.Value}");
            }
            else
            {
                Console.WriteLine("Failed to read the barcode.");
            }
        }
    }
}
