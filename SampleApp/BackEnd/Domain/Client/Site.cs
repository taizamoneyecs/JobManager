using BackEnd.Domain.ValueObjects;
using System.ComponentModel;
using System.Collections.Generic;
   
using BackEnd.Domain.Client;


namespace BackEnd.Domain.Client.Site
{
    public class Site
    {
        private readonly List<Site> _Sites = new(); // mutable internally
        public IReadOnlyList<Site> Sites => _Sites.AsReadOnly(); //immurtable externally

        public int SiteID { get; private set; }

        [ForeignKey("ClientID")]
        public int ClientID { get; set; }
        public Client Client { get; set; } //navigation property

        public required Address SiteAddress { get; set; }

        protected Site() { }

        public Site(int siteID,int clientID, Address SiteAddress)
                {
                    SiteID = siteID;
                    ClientID = clientID;
                    Address = new Address(address);
                } 

        
    }

}

