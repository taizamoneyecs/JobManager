namespace BackEnd.Domain.Job
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
        public void AssignEngineer(int engineerID)
        {
            EngineerID = engineerID;
            Status = JobStatus.Assigned;
        }

        public void UpdateStatus(JobStatus status)
        {
            Status = status;
        }

        public void UpdateAmount(decimal amount)
        {
            Amount = amount;
        }

        public void UpdateDescription(string description)
        {
            Description = description;
        }

        public void UpdateDate(DateOnly date)
        {
            Date = date;
        }   

        public void UpdateJobType(int jobTypeID)
        {
            JobTypeID = jobTypeID;
        }

        public void CancelJob()
        {
            Status = JobStatus.Cancelled;
        }

        public void CompleteJob()
        {
            Status = JobStatus.Completed;
        }

        public void StartJob()
        {
            Status = JobStatus.InProgress;
        }

        public void ApproveJob()
        {
            Status = JobStatus.Approved;
        }

        public void MarkPending()
        {
            Status = JobStatus.Pending;
        }

        public void UnassignEngineer()
        {
            EngineerID = 0;
            Status = JobStatus.Pending;
        }

       
    }

}
