namespace BackEnd.Application.Repository_Interfaces
{
    public interface IWageRepository<Wage> : IDisposable where Wage : class
    {
        IQueryable<Wage> GetWagesByID(Guid id);
        IQueryable<Wage> GetWagesByEngineerID(Guid engineerId);
        
        Task AddAsync(Wage entity);
        Task DeleteAsync(Wage entity);
        Task UpdateAsync(Wage entity);
    }
}
