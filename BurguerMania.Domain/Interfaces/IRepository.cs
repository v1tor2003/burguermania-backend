using BurguerMania.Domain.Common;

namespace BurguerMania.Domain.Interfaces
{
    public interface IRepository<PK, T> 
        where PK : IEntityKey
        where T : BaseEntity<PK>
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task <T?> GetByIdAsync(PK id);
        Task <IEnumerable<T>> GetAllAsync();
        Task SaveAsync();
    }
}