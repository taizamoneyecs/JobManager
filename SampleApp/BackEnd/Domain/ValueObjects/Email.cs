namespace BackEnd.Domain.ValueObjects
{
    public class Email
    {
        public string Value { get; }
        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Email cannot be null or empty.", nameof(value));
            }
            if (!IsValidEmail(value))
            {
                throw new ArgumentException("Invalid email format.", nameof(value));
            }
            Value = value;
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public override string ToString()
        {
            return Value;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Email other)
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
