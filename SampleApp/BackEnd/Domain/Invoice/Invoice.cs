using System;
using BackEnd.Domain.Client;
using BackEnd.Domain.Job;
using BackEnd.Domain.Enums;
using BackEnd.Domain.ValueObjects;

namespace BackEnd.Domain.Invoice
{
    public class Invoice
    {
        public int InvoiceID { get; private set; }

        [ForeignKey("ClientID")]
        public required int ClientID { get; set; }
        public Client Client { get; set; }  // navigation property - correct in model builder

        [ForeignKey("JobID")]
        public required int JobID { get; set; }
        public Job Job { get; set; }  // navigation property - correct in model builder

        public required DateTime DateCreated { get; set; }
        public required DateTime? DatePaid { get; set; }
        public required Balance InvoiceBalance { get; set; }
        public required InvoiceStatus Status { get; set; }

        protected Invoice() { }

        public Invoice(int invoiceID, int clientID, int jobID, DateTime dateCreated,DateTime datePaid, Balance InvoiceBalance, InvoiceStatus Status)
        {
            InvoiceID = invoiceID;
            ClientID = clientID;
            JobID = jobID;
            DateCreated = dateCreated;
            DatePaid = datePaid;
            Balance = new Balance(InvoiceBalance);
            InvoiceStatus = Status;
        }

        






    }
}
