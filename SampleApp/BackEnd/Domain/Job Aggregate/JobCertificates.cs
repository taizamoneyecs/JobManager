using BackEnd.Domain.Enums;
using BackEnd.Domain.Enums.CertificateName;
using BackEnd.Domain.Engineer;

namespace BackEnd.Domain.Job

{
    public class JobCertificates
    {
        public Guid ID { get;private set; }
        public Guid JobID { get; private set; }
        public Guid EngineerID { get; private set; }
        public CertificateName Name { get; private set; }

        protected JobCertificates() { }

        public JobCertificates(Guid ID,Guid jobID, Guid engineerID, CertificateName name)
        {
            ID = Guid.NewGuid();
            JobID = jobID;
            EngineerID = engineerID;
            Name = name;
           
        }

        


    }
}
