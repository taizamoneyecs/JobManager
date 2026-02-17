

namespace BackEnd.Domain.Domain_Services
{
    public class JobValidationService : DomainServices
    {
       private readonly IClientRepository _clientRepository;
       private readonly IJobRepository _jobRepository;
        public JobValidationService(IClientRepository clientRepository, IJobRepository jobRepository)
        {
            _clientRepository = clientRepository;
            _jobRepository = jobRepository;
        }
        public async Task<bool> ValidateJobAsync(Guid clientId, Guid siteId, JobCategory category, DateOnly scheduledDate)
        {
            // Validate client
            var client = await _clientRepository.GetByIdAsync(clientId);
            if (client == null)
                return false;
            // Validate site
            var site = await _clientRepository.GetSiteByIdAsync(siteId);
            if (site == null || site.ClientId != clientId)
                return false;
            // Validate job category
            if (!Enum.IsDefined(typeof(JobCategory), category))
                return false;
            // Validate scheduled date (e.g., must be in the future)
            if (scheduledDate <= DateOnly.FromDateTime(DateTime.Now))
                return false;
            return true;
        }
    }
}

// requires client, valid site,descriptionvalid job category and scheduled date  to be valid before a job can be raised.