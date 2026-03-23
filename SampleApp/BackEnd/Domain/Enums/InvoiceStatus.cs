using BackEnd.Domain.Enums;

namespace BackEnd.Domain.Enums
{
	public class InvoiceStatus : Enumeration

	{
		public static readonly InvoiceStatus None = new(0, "None");
		public static readonly InvoiceStatus Raised = new(1, "Raised");
		public static readonly InvoiceStatus Approved = new(2, "Approved");
		public static readonly InvoiceStatus Paid = new(3, "Paid");
		public static readonly InvoiceStatus Cancelled = new(4, "Cancelled");
		private InvoiceStatus() { }
		private InvoiceStatus(int id, string name) : base(id, name)
		{
		}
	}

}