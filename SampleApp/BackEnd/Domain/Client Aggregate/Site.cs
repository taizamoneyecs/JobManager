using BackEnd.Domain.ValueObjects;
using System.ComponentModel;

namespace BackEnd.Domain.Client.Site
{
    public class Site
    {
        private readonly List<Site> _Sites = new();
        public IReadOnlyList<Site> Sites => _Sites.AsReadOnly();

        public Guid ID { get; private set; }
        public Guid ClientID { get; set; }
        public required Address Address { get; set; }

        protected Site() { }

        public Site(Guid clientID, Address address)
                {
                    ID = Guid.NewGuid();
                    ClientID = clientID;
                    Address = address;
                }

        
    }

}

