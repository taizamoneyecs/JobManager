using BackEnd.Domain.Job;

using System;
using System.Linq;
using System.Linq.Expressions;

namespace BackEnd.Application.Repository_Interfaces
{
    public interface IJobRepository<Job> : IDisposable where Job : class
    {
        IQueryable<Job> GetJobsbyID(Guid id);
        IQueryable<Job> GetJobsByClientId(Guid clientId);
        IQueryable<Job> GetJobsByEngineerId(Guid engineerId);
        IQueryable<Job> GetJobsByStatus(Expression<Func<Job, bool>> statusExpression);
        IQueryable<Job> GetAllJobsByCategory(Expression<Func<Job, bool>> categoryExpression);

        IQueryable<JobCertificates> GetJobCertificatesByJobCategory(Job jobCategory);


        Task AddAsync(Job entity);
        Task DeleteAsync(Job entity);
        Task UpdateAsync(Job entity);
        Task AddJobCertificateAsync(JobCertificates jobCertificate);
        Task DeleteJobCertificateAsync(JobCertificates jobCertificate);


    }

       
}
