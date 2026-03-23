using BackEnd.Domain.Client.Site;
using BackEnd.Domain.Engineer;
using BackEnd.Domain.Client;
using BackEnd.Domain.Enums;
using BackEnd.Domain.ValueObjects;
using System;


namespace BackEnd.Domain.Job
{
    public class Job 
    {
        public int JobID { get; private set; }

        public required JobCategory Category { get; set; }
        public JobStatus Status { get; private set; }

        [ForeignKey("ClientID")]
        public required int ClientID { get; set; }
        public Client Client { get; set; }  // navigation property - correct in model builder

        [ForeignKey("SiteID")]
        public required int SiteID { get; set; }
        public Site Site { get; set; }  // navigation property - correct in model builder

        [ForeignKey("EngineerID")]
        public int? EngineerID { get; set; }
        public Engineer Engineer { get; set; }  // navigation property - correct in model builder


        public DateOnly ScheduledDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Description description { get; set; }
        

        protected Job() { }

        public Job(int jobID, JobCategory Category, JobStatus Status, int clientID, int siteID, DateOnly scheduledDate, Description description)
        {
           
            JobID = jobID;
            JobCategory = Category;
            JobStatus = Status;
            ClientID = clientID;
            SiteID = siteID;
            ScheduledDate = scheduledDate;
            Description = new Description(description);
        }

       
    }

}
