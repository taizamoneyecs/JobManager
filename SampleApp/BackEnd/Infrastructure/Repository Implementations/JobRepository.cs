using BackEnd.Application.Repository_Interfaces;
using BackEnd.Domain.Job;
using BackEnd.Infrastructure.Data;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace BackEnd.Infrastructure.Repository_Implementations
{
    public class JobRepository : IJobRepository<Job>, IDisposable 
    {
        private readonly AppDbContext _context;
        public JobRepository(AppDbContext context)
        {
            _context = context;
        }
        public IQueryable<Job> GetJobsbyID(Guid id)
        {
            return _context.Jobs.Where(j => j.ID == id);
        }
        public IQueryable<Job> GetJobsByClientId(Guid clientId)
        {
            return _context.Jobs.Where(j => j.ClientID == clientId);
        }
        public IQueryable<Job> GetJobsByEngineerId(Guid engineerId)
        {
            return _context.Jobs.Where(j => j.EngineerID == engineerId);
        }
        public IQueryable<Job> GetJobsByStatus(Expression<Func<Job, bool>> statusExpression)
        {
            return _context.Jobs.Where(statusExpression);
        }
        public IQueryable<Job> GetAllJobsByCategory(Expression<Func<Job, bool>> categoryExpression)
        {
            return _context.Jobs.Where(categoryExpression);
        }
  
        public async Task AddAsync(Job entity)
        {
            await _context.Jobs.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Job entity)
        {
            _context.Jobs.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Job entity)
        {
            _context.Jobs.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task AddJobCertificateAsync(JobCertificates jobCertificate)
        {
            await _context.JobCertificates.AddAsync(jobCertificate);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteJobCertificateAsync(JobCertificates jobCertificate)
        {
            _context.JobCertificates.Remove(jobCertificate);
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public IQueryable<JobCertificates> GetJobCertificatesByJobCategory(Job jobCategory)
        {
            throw new NotImplementedException();
        }
    }
}
