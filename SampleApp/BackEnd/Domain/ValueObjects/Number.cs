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
        public override string ToString()
        {
            return Value.ToString();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Number other)
            {
                return Value == other.Value;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}
