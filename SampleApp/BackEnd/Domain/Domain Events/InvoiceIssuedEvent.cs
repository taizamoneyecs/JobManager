using System;
using BackEnd.Domain.Invoice;

public class InvoiceIssuedEvent 
{
    public int InvoiceID { get; }
    public int JobID { get; }
    public int ClientID { get; }
    public InvoiceStatus Status { get; }
    public DateTime DateCreated { get; }

    public InvoiceIssuedEvent(int invoiceID, int jobID, int clientID, InvoiceStatus Status, DateTime DateCreated)
	{
        InvoiceID = invoiceID;
        JobID = jobID;
        ClientID = clientID;
        Status = Status;
        DateCreated = DateCreated;
          
		
    }

}
// add wage domain event and job certificate domain event and give all domian event namespaces.