using ATMApp.Services;
using ATMApp.Transactions.Abstract;
using ATMApp.Transactions.Concrete;

namespace ATMApp.ATM
{
    public class ATM
    {
        private AuthenticationService authService;
        private LogService logService;
        private EODService eodService;

        public ATM(AuthenticationService authService, LogService logService, EODService eodService)
        {
            this.authService = authService;
            this.logService = logService;
            this.eodService = eodService;
        }

        public void Start()
        {

            while (true)
            {
                Console.WriteLine("Please enter your username:");
                string username = Console.ReadLine();

                Console.WriteLine("Please enter your password:");
                string password = Console.ReadLine();

                if (!authService.Authenticate(username, password))
                {
                    logService.AddLog($"Failed login attempt for {username}.");
                    Console.WriteLine("Invalid credentials.");
                }
                else
                {
                    break;
                }
            }

            while(true)
            {
                Console.WriteLine("Welcome to ATM! Please choose an operation.");
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Payment");
                Console.WriteLine("4. End of Day");
                Console.WriteLine("5. Exit");


                string choice = Console.ReadLine();
                decimal amount;
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter amount to withdraw:");
                        amount = Decimal.Parse(Console.ReadLine());
                        Transaction withdraw = new Withdraw(amount);
                        withdraw.Execute();
                        logService.AddLog($"Withdraw executed: {amount}.");
                        break;

                    case "2":
                        Console.WriteLine("Enter amount to deposit:");
                        amount = Decimal.Parse(Console.ReadLine());
                        Transaction deposit = new Deposit(amount);
                        deposit.Execute();
                        logService.AddLog($"Deposit executed: {amount}.");
                        break;

                    case "3":
                        Console.WriteLine("Enter amount to pay:");
                        amount = Decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter recipient:");
                        string recipient = Console.ReadLine();
                        Transaction payment = new Payment(amount, recipient);
                        payment.Execute();
                        logService.AddLog($"Payment executed: {amount} to {recipient}.");
                        break;

                    case "4":
                        eodService.SaveEndOfDay(logService.GetLogs());
                        break;

                    case "5":
                        Environment.Exit(0);
                        break;

                    default:
                        logService.AddLog($"Unknown operation {choice} attempted.");
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
