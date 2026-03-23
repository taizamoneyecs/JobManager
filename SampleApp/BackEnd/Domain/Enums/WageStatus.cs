using System;
namespace BackEnd.Domain.Enums
{
	public class WageStatus : Enumeration
	{
		public static readonly WageStatus Unsettled = new(1, "Unsettled");
		public static readonly WageStatus Settled = new(2, "Settled");
		public static readonly WageStatus Paid = new(3, "Paid");
		private WageStatus() { }
		private WageStatus(int id, string name) : base(id, name)
		{
		}
    }
	


}