namespace BackEnd.Job
{
    public class JobCertificates
    {
        public required int ID { get; set; }
        public required int JobID { get; set; }
        public required int EngineerID { get; set; }
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
    }
}
