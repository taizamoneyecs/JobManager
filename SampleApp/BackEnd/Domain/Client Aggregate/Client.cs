using System.Security.Cryptography.X509Certificates;

namespace BackEnd.Domain.Client
{
    public class Client 
    {

        public int ClientID { get; private set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required long Number { get; set; }

        protected Client() { }

        public Client(int clientID,string name, string email, long number)
        {
            ClientID = clientID;
            Name = name;
            Email = email;
            Number = number;
        }

        



    }
        
    
}
