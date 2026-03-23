using System;
using BackEnd.Domain.Enums;

namespace BackEnd.Domain.Enums
{
	public class JobCategory : Enumeration
	{
		public static readonly JobCategory Renewable = new(1, "Renewable");
		public static readonly JobCategory Electrical = new(2, "Electrical");
		public static readonly JobCategory Gas = new(3, "Gas");

		private JobCategory() { }
		private JobCategory(int id, string name) : base(id, name)
		{
		}

	}
}