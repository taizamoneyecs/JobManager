
using BackEnd.Domain.Client;
using BackEnd.Domain.ValueObjects;

namespace BackEnd.Domain.Invoice
{
    public class Invoice
    {
        public Guid ID { get; private set; }
        public required Guid ClientID { get; set; }
        public required Guid JobID { get; set; }
        public required DateOnly DateCreated { get; set; }
        public required Money Amount { get; set; }
        public enum InvoiceStatus {
            Pending,
            Issued,
            Paid,
            Overdue

        }

        public required InvoiceStatus Status { get; set; }

        protected Invoice() { }
        public Invoice(Guid clientID, Guid jobID, DateOnly dateCreated, Money amount)
        {
            ClientID = clientID;
            JobID = jobID;
            DateCreated = dateCreated;
            Amount = amount;
            Status = InvoiceStatus.Pending;
        }

        






    }
}
