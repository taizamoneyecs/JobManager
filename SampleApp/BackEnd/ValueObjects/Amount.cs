namespace BackEnd.ValueObjects
{
    public class Amount
    {
        public decimal Value { get; }
        public Amount(float value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Amount cannot be negative.", nameof(value));
            }
            Value = (decimal)value;
        }
       
    }
}
