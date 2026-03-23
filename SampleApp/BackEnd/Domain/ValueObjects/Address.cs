namespace BackEnd.Domain.ValueObjects
{
    public record Address
    {
        public string Street { get; }
        public string City { get; }
        public string Country { get; }
        public string PostCode { get; }

       
        public Address(string street, string city, string country, string postCode)
        {
            if (string.IsNullOrWhiteSpace(street))
            {
                throw new ArgumentException("Street cannot be null or empty.", nameof(street));
            }
            if (string.IsNullOrWhiteSpace(city))
            {
                throw new ArgumentException("City cannot be null or empty.", nameof(city));
            }
            if (string.IsNullOrWhiteSpace(country))
            {
                throw new ArgumentException("Country cannot be null or empty.", nameof(country));
            }
            if (string.IsNullOrWhiteSpace(postCode))
            {
                throw new ArgumentException("PostCode cannot be null or empty.", nameof(postCode));
            }
            Street = street;
            City = city;
            Country = country;
            PostCode = postCode;
        }
       
        
    }
}
