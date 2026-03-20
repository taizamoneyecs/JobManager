namespace BackEnd.Domain.Domain_Services
{
    public class EngineerAssignmentService : DomainServices
    {
       private readonly IEngineerRepository _engineerRepository;
       private readonly IJobRepository _jobRepository;

        public EngineerAssignmentService(IEngineerRepository engineerRepository, IJobRepository jobRepository)
        {
            _engineerRepository = engineerRepository;
            _jobRepository = jobRepository;
        }
        public async Task <List<Engineer>> MatchEngineerToJobCategory(JobCategory jobCategory)// one to many 
        {
            var engineer = await _engineerRepository.GetbyTypeAsync()// sort enum classes

        }
          
        public async Task<bool> AssignEngineerToJobAsync(Guid jobId, Guid engineerId)
        {
            // Validate job
            var job = await _jobRepository.GetByIdAsync(jobId);
            if (job == null || job.Status != Job.JobStatus.Approved)
                return false;
            // Validate engineer ~ assign engineer if they are compatible with the job category and are available
            var engineer = await _engineerRepository.GetByIdAsync(engineerId);
            if (engineer == null || !engineer.IsAvailable)
                return false;
            // Assign engineer to job
            job.EngineerID = engineerId;
            job.Status = Job.JobStatus.Assigned;
            await _jobRepository.UpdateAsync(job);
            // Update engineer availability
            engineer.IsAvailable = false;
            await _engineerRepository.UpdateAsync(engineer);
            return true;
        }
    }
}
