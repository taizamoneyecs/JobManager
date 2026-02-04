using BackEnd.Application.Repository_Interfaces;
using BackEnd.Domain.Wage;
using BackEnd.Infrastructure.Data;
using System;
using System.Linq;
using System.Linq.Expressions;
namespace BackEnd.Infrastructure.Repository_Implementations
{
    public class WageRepository : IWageRepository<Wage>, IDisposable
    {
        readonly AppDbContext _context;
        public WageRepository(AppDbContext context)
        {
            _context = context;
        }
        public IQueryable<Wage> GetWagesByID(Guid id)
        {
            return _context.Wages.Where(w => w.ID == id);
            
        }
        public IQueryable<Wage> GetWagesByEngineerID(Guid engineerId)
        {
            return _context.Wages.Where(w => w.EngineerID == engineerId);
        }
       
        public async Task AddAsync(Wage entity)
        {
            await _context.Wages.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Wage entity)
        {
            _context.Wages.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Wage entity)
        {
            _context.Wages.Update(entity);
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            ((IDisposable)_context).Dispose();
        }

    }
}
