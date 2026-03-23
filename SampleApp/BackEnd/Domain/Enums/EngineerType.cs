using System;
using BackEnd.Domain.Enums;

namespace BackEnd.Domain.Enums
{

	public class EngineerType : Enumeration
	{
		public static readonly EngineerType Gas = new(1, "Gas");
		public static readonly EngineerType WetWork = new(2, "WetWork");
		public static readonly EngineerType Mechanical = new(3, "Mechanical");
		public static readonly EngineerType Electrical = new(4, "Electrical");
		public static readonly EngineerType CoreDrilling = new(5, "CoreDrilling");

		private EngineerType() { }
		private EngineerType(int id, string name) : base(id, name)
		{
		}

	}
}
