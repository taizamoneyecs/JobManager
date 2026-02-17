using System;
using BackEnd.Domain;

public class JobApprovedEvent : DomainEvent
{
	public JobApprovedEvent(Guid jobId, DateTime? approvedDate, Guid? approvedBy) 
    {
        JobId = jobId;
        ApprovedDate = approvedDate;
        ApprovedBy = approvedBy;
    }

    public Guid JobId { get; }
    public DateTime? ApprovedDate { get; }
    public Guid? ApprovedBy { get; }

}
