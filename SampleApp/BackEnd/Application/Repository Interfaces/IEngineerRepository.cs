using BackEnd.Domain.Job;
using System.Linq.Expressions;

namespace BackEnd.Application.Repository_Interfaces
{
    public interface IEngineerRepository <Engineer> : IDisposable where Engineer : class
    {
        IQueryable<Engineer> GetEngineersByID(Guid id);
        IQueryable<Engineer> GetEngineersByName(string name);
        IQueryable<Engineer> GetEngineersByType(Expression<Func<Engineer, bool>> typeExpression);

        Task AddSync(Engineer entity);
        Task DeleteSync(Engineer entity);
        Task UpdateSync(Engineer entity);



    }
}
