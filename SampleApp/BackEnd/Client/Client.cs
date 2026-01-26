namespace BackEnd.Client
{
    public class Client
    {
        private readonly List<Site> _Sites = new();
        public IReadOnlyList<Site> Sites => _Sites.AsReadOnly();

        public int ID { get; private set; }
        public required string Name { get; set; }
        public required string Email { get; set; } 
        public required long Number  { get; set; }

       
        protected Client() { }

        public Client(string name, string email, long number)
        {
            Name = name;
            Email = email;
            Number = number;
        }
        public void AddSite(Site site)
        {
            _Sites.Add(site);
        }
        
        public void RemoveSite(Site site)
        {
            _Sites.Remove(site);
        }

    }
    public class Site
    {

        public int ID { get; private set; }
        public int ClientID { get; private set; }
        public string? Address { get; private set; }

        protected Site() { }

        public Site(int clientID, string? address)
        {
            ClientID = clientID;
            Address = address;
        }

        
    }
}
