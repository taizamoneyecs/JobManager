using BackEnd.Application.Repository_Interfaces;
using BackEnd.Domain.Engineer;
using BackEnd.Infrastructure.Data;
using System;
using System.Linq;
using System.Linq.Expressions;


namespace BackEnd.Infrastructure.Repository_Implementations
{
    public class EngineerRepository : IEngineerRepository<Engineer>, IDisposable

    {
        private readonly AppDbContext _context;
        public EngineerRepository(AppDbContext context)
        {
            _context = context;
        }
        public IQueryable<Engineer> GetEngineersByID(Guid id)
        {
            return _context.Engineers.Where(e => e.ID == id);

        }
        public IQueryable<Engineer> GetEngineersByName(string name)
        {
            return _context.Engineers.Where(e => e.Name == name);
        }
        public IQueryable<Engineer> GetEngineersByType(Expression<Func<Engineer, bool>> typeExpression)
        {
            return _context.Engineers.Where(typeExpression);
        }
        
        public async Task AddAsync(Engineer entity)
        {
            await _context.Engineers.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Engineer entity)
        {
            _context.Engineers.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Engineer entity)
        {
            _context.Engineers.Update(entity);
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            ((IDisposable)_context).Dispose();
        }
    }
}
