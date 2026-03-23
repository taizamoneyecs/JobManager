using System;
using BackEnd.Domain.Job;
using BackEnd.Domain.Engineer;

public class JobCompletedEvent 
{
	public int JobID { get; }
	public int EngineerID { get; }
	public DateTime EndDate { get; }

    public JobCompletedEvent(int jobID, int engineerId, DateTime endDate)
	{
		JobID = jobID;
		EngineerID = engineerId;
		EndDate = endDate;
    }
}

