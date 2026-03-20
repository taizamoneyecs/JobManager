using BackEnd.Domain.ValueObjects;
using System;


namespace BackEnd.Domain.Job
{
    public class Job 
    {
        public Guid ID { get; private set; }

        public enum JobStatus
        {
            Raised,
            Pending,
            Approved,
            Assigned,
            InProgress,
            Completed,
            Cancelled
        }
        public required JobStatus Status { get; set; }

        public enum JobCategory
        {
            Renewable,
            Electrical,
            Gas,
        }
        public JobCategory? Category { get; set; }
        public required Guid ClientID { get; set; }
        public required Guid SiteID { get; set; }
        public Guid? EngineerID { get; set; }
        public DateOnly ScheduledDate { get; set; }
        public DateTime? RaisedDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public Guid? ApprovedBy { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public required string Desc { get; set; }
        public decimal? Amount { get; set; }

        protected Job() { }

        public Job(Guid jobTypeID, Guid clientID, Guid siteID, DateOnly scheduledDate, string desc)
        {
           
            ClientID = clientID; 
            SiteID = siteID;
            ScheduledDate = scheduledDate;
            Desc = desc;
            Status = JobStatus.Raised;
        }

       
    }

}
