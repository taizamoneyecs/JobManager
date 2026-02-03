namespace BackEnd.Domain.Job
{
    public class JobCertificates
    {
        public Guid ID { get;private set; }
        public Guid JobID { get; private set; }
        public Guid EngineerID { get; private set; }
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
        public JobCertificates(Guid jobID, Guid engineerID, CertificateName name, DateTime expiryDate)
        {
            JobID = jobID;
            EngineerID = engineerID;
            Name = name;
            ExpiryDate = expiryDate;
        }

        


    }
}
