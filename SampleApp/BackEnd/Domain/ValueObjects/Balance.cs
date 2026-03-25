
namespace BackEnd.Domain.ValueObjects
{
    public record Balance
    {
        public decimal Amount { get; private set; }
        protected Balance() { }
        public Balance(decimal amount) // correct the use of amount 
        {
            if (amount < 0)
            {
                throw new ArgumentException("Balance cannot be negative.");
            }
            Amount = amount;
        }
        public void Add(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount to add cannot be negative.");
            }
            Amount += amount;
        }
        public void Subtract(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount to subtract cannot be negative.");
            }
            if (Amount - amount < 0)
            {
                throw new InvalidOperationException("Insufficient balance.");
            }
            Amount -= amount;
        }
    }
}   