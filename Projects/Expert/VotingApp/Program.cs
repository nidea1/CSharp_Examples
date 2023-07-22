using VotingApp.Entities.User;
using VotingApp.Services.Register;
using VotingApp.Services.Voting;

namespace VotingApp
{
    class Program
    {
        static void Main()
        {
            IVotingService votingService = new VotingService();
            IRegisterService registerService= new RegisterService();
            

            while (true)
            {
                try
                {
                    string username = GetUsername();

                    if (!registerService.IsRegistered(username))
                    {
                        registerService.Register(new User(username));
                    }

                    votingService.DisplayCategories();
                    int choice = GetUserChoice();

                    votingService.Vote(username, choice);

                    if (!AskToContinue())
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            votingService.DisplayResults();
        }

        private static string GetUsername()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new Exception("Username can't be blank!");
            }

            return username;
        }

        private static int GetUserChoice()
        {
            Console.Write("Select a category: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                throw new Exception("Please enter a valid choice!");
            }

            return choice;
        }

        private static bool AskToContinue()
        {
            Console.WriteLine("Continue voting? (Y/N)");
            string? input = Console.ReadLine()?.ToLower();

            switch (input)
            {
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    throw new Exception("Your select must be (Y) or (N)!");
            }
        }
    }
}
