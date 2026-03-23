using System;
using BackEnd.Domain.Client;
using BackEnd.Domain.Job;
using BackEnd.Domain.Invoice;
using BackEnd.Domain.Engineer;
using BackEnd.Domain.Enums;

namespace BackEnd.Domain.Domain_Events
{
	public class JobRaisedEvent 
	{
        public int JobID { get; }
        public int ClientID { get; }
        public int SiteID { get; }
        public JobCategory Category { get; }
        public DateOnly ScheduledDate { get; }
        
        

        public JobRaisedEvent(int jobID, int clientID, int siteID, JobCategory category, DateOnly scheduledDate)
		{
			JobID = jobID;
            ClientID = clientID;
            SiteID = siteID;
            JobCategory = category;
            ScheduledDate = scheduledDate;


		}

		
	}
}