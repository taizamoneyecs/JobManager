namespace BackEnd.Invoice
{
    public class Invoice
    {
        public  int ID { get; private set; }
        public int ClientID { get; private set; }
        public int JobID { get; private set; }
        public required DateOnly Date { get; set; }
        public required decimal Amount { get; set; }
        public required bool Paid { get; set; }

        protected Invoice() { }
        public Invoice(int clientID, int jobID, DateOnly date, decimal amount)
        {
            ClientID = clientID;
            JobID = jobID;
            Date = date;
            Amount = amount;
            Paid = false;
        }

        
    }
}
