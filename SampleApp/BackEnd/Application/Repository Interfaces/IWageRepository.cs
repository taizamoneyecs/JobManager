using BackEnd.Domain.Wage
namespace BackEnd.Application.Repository_Interfaces
{
    public interface IWageRepository
    {
        Task AddAsync(Wage wage);
        Task DeleteAsync(Wage wage);
        Task UpdateAsync(Wage wage);

        Task<Wage?> GetWagesByID(Guid id);
        Task<List<Wage>> GetWagesByEngineerID(Guid engineerId);
        
        
    }
}
