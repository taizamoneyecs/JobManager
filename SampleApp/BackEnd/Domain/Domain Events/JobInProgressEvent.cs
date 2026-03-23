using System;
using BackEnd.Domain.Job;

public class JobInProgressEvent
{
    public int JobID { get; }
	public DateOnly ScheduledDate { get; }
	public DateTime StartDate { get; }


    public JobInProgressEvent(int jobID, DateOnly scheduledDate, DateTime startDate) 
	{
		JobID = jobID;
		ScheduledDate = scheduledDate;
		StartDate = startDate;
	}
	
}


