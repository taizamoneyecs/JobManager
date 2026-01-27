namespace BackEnd.Domain.ValueObjects
{
    public class Description
    {
        public string Value { get; }
        public Description(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Description cannot be null or empty.", nameof(value));
            }
            if (value.Length > 500)
            {
                throw new ArgumentException("Description cannot exceed 500 characters.", nameof(value));
            }
            Value = value;
        }
        public override string ToString()
        {
            return Value;
        }
        
    }
}
