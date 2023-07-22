using ATMApp.Transactions.Abstract;

namespace ATMApp.Transactions.Concrete
{
    public class Deposit : Transaction
    {
        public Deposit(decimal amount) : base(amount) { }

        public override void Execute()
        {
            Console.WriteLine($"Deposited {Amount}.");
        }
    }
}
