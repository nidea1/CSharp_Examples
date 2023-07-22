using ATMApp.Transactions.Abstract;

namespace ATMApp.Transactions.Concrete
{
    class Payment : Transaction
    {
        public string PaymentTo { get; set; }

        public Payment(decimal amount, string paymentTo) : base(amount)
        {
            PaymentTo = paymentTo;
        }

        public override void Execute()
        {
            Console.WriteLine($"Paid {Amount} to {PaymentTo}.");
        }
    }
}
