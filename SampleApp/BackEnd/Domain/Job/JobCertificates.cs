namespace BackEnd.Domain.Job
{
    public class JobCertificates
    {
        public int ID { get;private set; }
        public int JobID { get; private set; }
        public int EngineerID { get; private set; }
        public enum CertificateName { 
            MWC, 
            EIC, 
            BR, 
            CP12, 
            PartF,
            PIBI
        }

        public required CertificateName Name { get; set; }
        public required DateTime ExpiryDate { get; set; }

        protected JobCertificates() { }
        public JobCertificates(int jobID, int engineerID, CertificateName name, DateTime expiryDate)
        {
            JobID = jobID;
            EngineerID = engineerID;
            Name = name;
            ExpiryDate = expiryDate;
        }

        public bool IsExpired()
        {
            return DateTime.Now > ExpiryDate;
        }

        public void AssignCertificateToJob(int jobID)
        {
            JobID = jobID;
        }
        public void AssignCertificateToEngineer(int engineerID)
        {
            EngineerID = engineerID;
        }


    }
}
