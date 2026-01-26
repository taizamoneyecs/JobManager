namespace BackEnd.Job
{
    public class Job
    {
        private readonly List<JobCertificates> _JobCertificates = new();
        public IReadOnlyList<JobCertificates> JobCertificates => _JobCertificates.AsReadOnly();
        public int ID { get; private set; }
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
        public decimal Amount { get; set; }

        protected Job() { }

        public Job(int jobTypeID, int clientID, int siteID, DateOnly date, string description)
        {
            JobTypeID = jobTypeID;
            ClientID = clientID;
            SiteID = siteID;
            Date = date;
            Description = description;
            Status = JobStatus.Pending;
        }

        public void AddCertificate(JobCertificates certificate)
        {
            _JobCertificates.Add(certificate);
        }
        public void RemoveCertificate(JobCertificates certificate)
        {
            _JobCertificates.Remove(certificate);
        }
    }
}
