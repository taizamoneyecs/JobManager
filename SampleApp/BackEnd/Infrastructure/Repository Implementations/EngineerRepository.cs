using BackEnd.Application.Repository_Interfaces;
using BackEnd.Domain.Engineer;
using BackEnd.Infrastructure.Data;
using System;
using System.Linq;
using System.Linq.Expressions;


namespace BackEnd.Infrastructure.Repository_Implementations
{
    public class EngineerRepository : IEngineerRepository

    {
        private readonly AppDbContext _context;
        public EngineerRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Engineer engineer)
        {
            _context.Engineers.Add(engineer);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var engineer = await _context.Engineers.FindAsync(id);
            if (engineer != null)
            {
                _context.Engineers.Remove(engineer);
                await _context.SaveChangesAsync();

            }
        }
        public async Task UpdateAsync(Engineer engineer)
        {
            _context.Engineers.Update(engineer);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Engineer>> GetByNameAsync(string name)
        {
            var engineer = await _context.Engineers
                .Where(e => e.Name == name)
                .ToListAsync();
            return engineer;
        }

        public async Task<List<Engineer>> GetbyTypeAsync(Expression<Func<Engineer, bool>> typeExpression)
        {
            var engineer = await _context.Engineers
                .Where(typeExpression)
                .ToListAsync();
                return engineer;

        }
        public async Task<List<Engineer>> GetAllAsync()
        {
            return await _context.Engineers.ToListAsync();
        }

          

    }
}
