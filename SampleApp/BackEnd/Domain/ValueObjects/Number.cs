namespace BackEnd.Domain.ValueObjects
{
    public class Number
    {
        public long Value { get; }
        public Number(long value)
        {
            if (value == 0)
            {
                throw new ArgumentException("Number cannot be zero.", nameof(value));
            }
            if (value <= 0)
            {
                throw new ArgumentException("Number must be a positive integer.", nameof(value));
            }
            Value = value;

            if (value.length <10 || value.length > 15)
            {
                throw new ArgumentException("Number must be between 10 and 15 digits long.", nameof(value));
            }

           
            if (!value.StartsWith("+44") && !value.StartsWith("0"))
            {
                throw new ArgumentException("Number must start with +44 or 0.", nameof(value));
            }
        }

    }
}
