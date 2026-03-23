using System;
using BackEnd.Domain.Client;
using BackEnd.Domain.Job;
using BackEnd.Domain.Invoice;
using BackEnd.Domain.Engineer;
using BackEnd.Domain.Enums;

public class JobSettledEvent
{
	public int JobID { get; }
	public int EngineerID { get; }
	public int ClientID { get; }
	public int SiteID { get; }
	public InvoiceStatus InvoiceStatus { get; }
	public WageStatus WageStatus { get; }

    public JobSettledEvent(int jobID, int engineerID,int clientID,int siteID, InvoiceStatus status, WageStatus status)
	{
		JobID = jobID;
		EngineerID = engineerID;
		ClientID = clientID;
		SiteID = siteID;
		InvoiceStatus = status;
		WageStatus = status;

    }
}
