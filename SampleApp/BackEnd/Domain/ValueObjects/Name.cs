namespace BackEnd.Domain.ValueObjects
{
    public class Name
    {
        public string FirstName { get;}
        public string? LastName { get;}
        
        public Name(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("First name cannot be null or empty.", nameof(firstName));
            }

            FirstName = firstName;
            LastName = lastName;
        }
        
        public override string ToString()
        {
            return LastName is null ? FirstName : $"{FirstName} {LastName}";
        }

        
    }
}
