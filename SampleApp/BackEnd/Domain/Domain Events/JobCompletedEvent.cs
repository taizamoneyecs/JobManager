using System;

public class JobCompletedEvent : DomainEvent
{
	public JobCompletedEvent(Guid jobId, Guid engineerId, DateTime endDate)
	{
		JobId = jobId;
		EngineerId = engineerId;
		EndDate = endDate;
    }
}
