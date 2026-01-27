using static BackEnd.Domain.Job.JobCertificates;

namespace BackEnd.Domain.JobType
{
    public class JobType

    {
        private readonly List<CertificateName> _certificateRequired = new();    
        public IReadOnlyList<CertificateName> CertificateRequired => _certificateRequired.AsReadOnly();

        public int ID { get; private set; }
        public required string Name { get; set; }

        protected JobType() { }
        public JobType(string name)
        {
            Name = name;
        }
        public void AddCertificateRequirement(CertificateName certificate)
        {
            _certificateRequired.Add(certificate);
        }
        public void RemoveCertificateRequirement(CertificateName certificate)
        {
            _certificateRequired.Remove(certificate);
        }

       


    }
}
