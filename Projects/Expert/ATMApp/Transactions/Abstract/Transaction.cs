namespace ATMApp.Transactions.Abstract
{
    public abstract class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public Transaction(decimal amount)
        {
            Amount = amount;
            TransactionDate = DateTime.Now;
        }

        public abstract void Execute();
    }
}
