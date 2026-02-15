
using BackEnd.Domain.Engineer


namespace BackEnd.Application.Repository_Interfaces
{
    public interface IEngineerRepository 
    {
        Task AddAsync(Engineer engineer);
        Task DeleteAsync(Engineer id);
        Task UpdateAsync(Engineer engineer);
        
        Task<List<Engineer>> GetByNameAsync(string name);
        Task<List<Engineer>> GetbyTypeAsync(Expression<Func<Engineer, bool>> typeExpression);
        Task<List<Engineer>> GetAllAsync();

       

    }
}
