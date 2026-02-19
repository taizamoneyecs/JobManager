using System;

public class CalculateWageService : DomainServices
{
	private readonly IJobRepository _jobRepository;
	private readonly IEngineerRepository _engineerRepository;

	public CalculateWageService(IJobRepository jobRepository, IEngineerRepository engineerRepository)
	{
		_jobRepository = jobRepository;
		_engineerRepository = engineerRepository;
    }

	public async Task<decimal> CalculateWageForJobAsync(Guid jobId)
    {
		var job = await _jobRepository.GetByIdAsync(jobId);
		if (job == null || job.EngineerID == null)
			throw new InvalidOperationException("Job not found or engineer not assigned.");
		var engineer = await _engineerRepository.GetByIdAsync(job.EngineerID.Value);
		if (engineer == null)
			throw new InvalidOperationException("Engineer not found.");
		// Calculate wage based on job category and engineer type
		decimal baseWage = GetBaseWageForJobCategory(job.Category);
		decimal engineerMultiplier = GetMultiplierForEngineerType(engineer.EngineerType);
		return baseWage * engineerMultiplier;

    }
