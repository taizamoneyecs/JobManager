using BackEnd.Domain.ValueObjects;

namespace BackEnd.Domain.Job
{
    public class Job 
    {
        public Guid ID { get; private set; }
        public required Guid JobTypeID { get; set; }

        public enum JobStatus
        {
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
        public required DateOnly ScheduledDate { get; set; }
        public required Description Desc { get; set; }
        public Money? Amount { get; set; }

        protected Job() { }

        public Job(Guid jobTypeID, Guid clientID, Guid siteID, DateOnly scheduledDate, Description desc)
        {
            JobTypeID = jobTypeID;
            ClientID = clientID; 
            SiteID = siteID;
            ScheduledDate = scheduledDate;
            Desc = desc;
            Status = JobStatus.Pending;
        }

       
    }

}
