using System;

public class InvoicePaidEvent : DomainEvent
{
	public InvoicePaidEvent(Guid invoiceId, Guid jobId,Guid clientId, decimal amount, DateTime paidDate)
	{
		InvoiceId = invoiceId;
		JobId = jobId;
		ClientId = clientId;
        Amount = amount;
		PaidDate = paidDate;
	}
	public Guid InvoiceId { get; }
	public Guid JobId { get; }
	public decimal Amount { get; }
	public DateTime PaidDate { get; }
}
