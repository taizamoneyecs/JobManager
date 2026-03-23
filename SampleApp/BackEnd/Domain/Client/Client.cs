using System.Security.Cryptography.X509Certificates;
using BackEnd.Domain.ValueObjects;

namespace BackEnd.Domain.Client
{
    public class Client 
    {

        public int ClientID { get; private set; }
        public required string Name { get; private set; }
        public required  Email ClientEmail { get; private set; }
        public required Number ClientNumber { get; private set; }

        protected Client() { }

        public Client(int clientID,string name, Email ClientEmail, Number ClientNumber)
        {
            ClientID = clientID;
            Name = name;
            Email = new Email(email);
            Number = new Number(number);
        }

        



    }
        
    
}
