using System;

public class JobAssignedEvent : DomainEvent
{
	public JobAssignedEvent(Guid jobId, Guid engineerId, DateTime? assignedDate) 
	{
		JobId = jobId;
		EngineerId = engineerId;
		AssignedDate = assignedDate;
	}
	public Guid JobId { get; }
	public Guid EngineerId { get; }
	public DateTime? AssignedDate { get; }

}
