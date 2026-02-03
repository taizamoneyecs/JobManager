namespace BackEnd.Domain.ValueObjects
{
    public record Money
    {
       public decimal Amount { get; }
       public required string Currency { get; init; } = "GBP";

       public Money(decimal amount, string currency)
       {
           if (amount < 0)
           {
               throw new ArgumentException("Amount cannot be negative.", nameof(amount));
           }
           Amount = amount;
           Currency = currency;
        }


    }
}
