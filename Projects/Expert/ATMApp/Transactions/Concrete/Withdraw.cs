using ATMApp.Transactions.Abstract;

namespace ATMApp.Transactions.Concrete
{
    class Withdraw : Transaction
    {
        public Withdraw(decimal amount) : base(amount) { }

        public override void Execute()
        {
            Console.WriteLine($"Withdrew {Amount}.");
        }

        public static implicit operator System.Transactions.Transaction(Withdraw v)
        {
            throw new NotImplementedException();
        }
    }
}
