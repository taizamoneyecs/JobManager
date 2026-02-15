using BackEnd.Application.Repository_Interfaces;
using BackEnd.Domain.Job;
using BackEnd.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace BackEnd.Infrastructure.Repository_Implementations
{
    public class JobRepository : IJobRepository 
    {
        private readonly AppDbContext _context;
        public JobRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Job job)
        {
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var job = await _context.Jobs.FindAsync(id);
            if (job != null)
            {
                _context.Jobs.Remove(job);
                await _context.SaveChangesAsync();
            }
        }
        public async Task UpdateAsync(Job job)
        {
            _context.Jobs.Update(job);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Job>> GetAllAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

        public async Task<Job?> GetJobsbyIDAsync(Guid id)
        {
            return await _context.Jobs.FindAsync(id);
        }

        public async Task<List<Job>> GetJobsbySiteIdAsync(Guid siteId)
        {
            var jobs = await _context.Jobs
                .Where(j => j.SiteId == siteId)
                .ToListAsync();
            return jobs;

        }
        public async Task<List<Job>> GetJobsByClientIdAsync(Guid clientId)
        {
            var jobs = await _context.Jobs
                .Where(j => j.ClientId == clientId)
                .ToListAsync();
            return jobs;
        }
        public async Task<List<Job>> GetJobsByEngineerIdAsync(Guid engineerId)
        {
            var jobs = await _context.Jobs
                .Where(j => j.EngineerId == engineerId)
                .ToListAsync();
            return jobs;
        }
        public async Task<List<Job>> GetJobsByStatusAsync(Expression<Func<Job, bool>> statusExpression)
        {
            var jobs = await _context.Jobs
                .Where(statusExpression)
                .ToListAsync();
            return jobs;
        }
        public async Task<List<Job>> GetAllJobsByCategoryAsync(Expression<Func<Job, bool>> categoryExpression)
        {
            var jobs = await _context.Jobs
                .Where(categoryExpression)
                .ToListAsync();
            return jobs;
        }
        public async Task AddJobCertificateAsync(JobCertificates jobCertificate)
        {
            _context.JobCertificates.Add(jobCertificate);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteJobCertificateAsync(JobCertificates jobCertificate)
        {
            _context.JobCertificates.Remove(jobCertificate);
            await _context.SaveChangesAsync();
        }

    }
}
