using System;

public class JobInProgressEvent : DomainEvent
{
	public JobInProgressEvent(Guid jobId, DateTime? inProgressDate) //change to current date time 
	{
		JobId = jobId;
		InProgressDate = inProgressDate;
	}
	public Guid JobId { get; }
	public DateTime? InProgressDate { get; }

}
