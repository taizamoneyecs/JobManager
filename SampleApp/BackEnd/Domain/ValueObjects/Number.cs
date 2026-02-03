namespace BackEnd.Domain.ValueObjects
{
    public class Number
    {
        public long Value { get; }
        public Number(long value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Number must be a positive integer.", nameof(value));
            }
            Value = value;
        }
       
    }
}
