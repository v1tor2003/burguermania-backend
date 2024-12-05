using System.Linq.Expressions;
using BurguerMania.Domain.Common;

namespace BurguerMania.Domain.Interfaces
{
    public interface IRepository<PK, T> 
        where PK : IEntityKey
        where T : BaseEntity<PK>
    {
        abstract IQueryable<T> BuildQueryWithIncludes(params Expression<Func<T, object>>[] includes);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task <T?> GetByIdAsync(PK id);
        Task <IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(PK id, params Expression<Func<T, object>>[] includes);
        Task SaveAsync();
    }
}