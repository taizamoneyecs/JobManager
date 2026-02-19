using System;

public class JobSettledEvent : DomainEvent
{
	public JobSettledEvent(Guid jobId, Guid engineerId,Guid clientID,Guid siteID, DateTime settledDate)
	{
		JobId = jobId;
		ClientID = clientID;
		SiteID = siteID;
        EngineerId = engineerId;
		SettledDate = settledDate;
    }
}
