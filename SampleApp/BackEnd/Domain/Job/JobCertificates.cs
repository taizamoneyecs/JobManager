using BackEnd.Domain.Enums;

using BackEnd.Domain.Engineer;

namespace BackEnd.Domain.Job

{
    public class JobCertificates
    {
        public int CertificateID { get;private set; }

        [ForeignKey("JobID")]
        public int JobID { get; private set; }
        public Job Job { get; set; } //navigation property

        [ForeignKey("EngineerID")]
        public int EngineerID { get; private set; }
        public Engineer Engineer { get; set; } //navigation property

        public CertificateName Name { get; private set; }

        protected JobCertificates() { }

        public JobCertificates(int certificateID, int jobID, int engineerID, CertificateName Name)
        {
            CertificateID = certificateID;
            JobID = jobID;
            EngineerID = engineerID;
            CertificateName = Name;

        }

        


    }
}
