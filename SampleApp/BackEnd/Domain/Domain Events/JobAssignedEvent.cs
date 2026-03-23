using System;
using BackEnd.Domain.Engineer;
using BackEnd.Domain.Job;

public class JobAssignedEvent 
{
	public int JobID { get; }
	public int EngineerID { get; }
	public DateOnly ScheduledDate { get; }

    public JobAssignedEvent(int jobID, int engineerID, DateOnly scheduledDate) 
	{
		JobID = jobID;
		EngineerID = engineerID;
		ScheduledDate = scheduledDate;
	}
	
}
