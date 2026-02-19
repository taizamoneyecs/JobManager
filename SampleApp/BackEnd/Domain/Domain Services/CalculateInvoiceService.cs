using System;

public class CalculateInvoiceService : DomainServices
{
    private readonly IJobRepository _jobRepository;
    private readonly IClientRepository _clientRepository;

    public CalculateInvoiceService(IJobRepository jobRepository, IClientRepository clientRepository)
    {
        _jobRepository = jobRepository;
        _clientRepository = clientRepository;
    }

    public async Task<decimal> CalculateInvoiceForJobAsync(Guid jobId)
    {
        var job = await _jobRepository.GetByIdAsync(jobId);
        if (job == null || job.ClientID == null)
            throw new InvalidOperationException("Job not found or client not assigned.");
        var client = await _clientRepository.GetByIdAsync(job.ClientID.Value);
        if (client == null)
            throw new InvalidOperationException("Client not found.");
        // Calculate invoice based on job category, client type, and any additional factors (e.g., discounts, taxes)
        decimal baseInvoice = GetBaseInvoiceForJobCategory(job.Category);
        decimal clientMultiplier = GetMultiplierForClientType(client.ClientType);
        return baseInvoice * clientMultiplier;
    }
}
