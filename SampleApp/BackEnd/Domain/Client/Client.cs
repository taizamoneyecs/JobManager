using System.Security.Cryptography.X509Certificates;

namespace BackEnd.Domain.Client
{
    public class Client
    {

        public Guid ID { get; private set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required long Number { get; set; }

        protected Client() { }

        public Client(string name, string email, long number)
        {
            ID = Guid.NewGuid();
            Name = name;
            Email = email;
            Number = number;
        }

        



    }
        
    
}
