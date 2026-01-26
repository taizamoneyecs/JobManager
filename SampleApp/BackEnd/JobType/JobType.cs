using static BackEnd.Job.JobCertificates;

namespace BackEnd.JobType
{
    public class JobType
    {
        public required int ID { get; set; }
        public required string Name { get; set; }

        public required List<CertificateName> CertificateRequired { get; set; }

    }
}
