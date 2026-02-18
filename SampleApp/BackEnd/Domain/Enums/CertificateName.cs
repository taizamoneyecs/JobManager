using System;

public class CertificateName : Enumeration
{
	public static readonly CertificateName MWC = new(1, "MWC");	
	public static readonly CertificateName EIC = new(2, "EIC");
	public static readonly CertificateName BR = new(3, "BR");
	public static readonly CertificateName CP12 = new(4, "CP12");
	public static readonly CertificateName PartF = new(5, "PartF");
	public static readonly CertificateName PIBI = new(6, "PIBI");

	private CertificateName() { }
	private CertificateName(int id, string name) : base(id, name)
	{
    }
}
