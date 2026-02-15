using BackEnd.Domain.Job;
using BackEnd.Domain.Job.JobCertficates;

using System;
using System.Linq;
using System.Linq.Expressions;

namespace BackEnd.Application.Repository_Interfaces
{
    public interface IJobRepository
    {
        Task AddAsync(Job job);
        Task DeleteAsync(Guid job);
        Task UpdateAsync(Job job);
        Task<List<Job>> GetAllAsync();

        Task <Job?>GetJobsbyIDAsync(Guid id);
        Task<List<Job>> GetJobsbySiteIdAsync(Guid siteId);
        Task<List<Job> GetJobsByClientIdAsync(Guid clientId);
        Task<List<Job>> GetJobsByEngineerIdAsync(Guid engineerId);
        Task<List<Job>> GetJobsByStatusAsync(Expression<Func<Job, bool>> statusExpression);
        Task<List<Job>> GetAllJobsByCategoryAsync(Expression<Func<Job, bool>> categoryExpression);
        Task AddJobCertificateAsync(JobCertificates jobCertificate);
        Task DeleteJobCertificateAsync(JobCertificates jobCertificate);


    }
    

}
