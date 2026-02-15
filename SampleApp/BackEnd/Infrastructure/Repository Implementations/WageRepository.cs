using BackEnd.Application.Repository_Interfaces;
using BackEnd.Domain.Wage;
using BackEnd.Infrastructure.Data;
using System;
using System.Linq;
using System.Linq.Expressions;
namespace BackEnd.Infrastructure.Repository_Implementations
{
    public class WageRepository : IWageRepository
    {
        readonly AppDbContext _context;
        public WageRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Wage wage)
        {
            _context.Wages.Add(wage);
            await _context.SaveChangesAsync();

        }
        public async Task DeleteAsync(Guid id)
        {
            var wage = await _context.Wages.FindAsync(id);
            if (wage != null)
            {
                _context.Wages.Remove(wage);
                await _context.SaveChangesAsync();
            }
        }
        public async Task UpdateAsync(Wage wage)
        {
            _context.Wages.Update(wage);
            await _context.SaveChangesAsync();
        }


        public async Task<Wage?> GetWageByIDAsync(Guid id)
        {
            return await _context.Wages.FindAsync(id);
        }

        public async Task<List<Wage>> GetWagesByEngineerIDAsync(Guid engineerId)
        {
            var wages = await _context.Wages
                .Where(w => w.EngineerId == engineerId)
                .ToListAsync();
            return wages;
        }


    }
}
