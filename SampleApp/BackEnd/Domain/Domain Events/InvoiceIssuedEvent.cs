using System;

public class InvoiceIssuedEvent : DomainEvent
{
	public InvoiceIssuedEvent(Guid invoiceId, Guid jobId,Guid clientID, decimal amount, DateTime issuedDate)
	{
		InvoiceId = invoiceId;
		JobId = jobId;
		ClientID = clientID;
        Amount = amount;
		IssuedDate = issuedDate;
    }

}
