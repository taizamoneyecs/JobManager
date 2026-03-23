using System;


using BackEnd.Domain.Invoice;

public class InvoicePaidEvent 
{
    public int InvoiceID { get; }
    public InvoiceStatus Status { get; }
    public DateTime DatePaid { get; }
   

    public InvoicePaidEvent(int invoiceID, InvoiceStatus status, DateTime DatePaid)
	{
        InvoiceID = invoiceID;
        Status = status;
        DatePaid = DatePaid;
        
	}
	
}
