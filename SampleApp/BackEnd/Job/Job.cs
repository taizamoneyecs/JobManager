namespace BackEnd.Job
{
    public class Job
    {
        public required int ID { get; set; }
        public required int JobTypeID { get; set; }

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
        public required int ClientID { get; set; }
        public required int SiteID { get; set; }
        public int EngineerID { get; set; }
        public required DateOnly Date { get; set; }
        public required string Description { get; set; }
        public decimal Cost { get; set; }
    }
}
