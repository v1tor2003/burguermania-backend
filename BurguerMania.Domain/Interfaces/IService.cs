using BurguerMania.Domain.Common;

namespace BurguerMania.Domain.Interfaces
{
    public interface IService<PK, T> 
        where PK : IEntityKey
        where T : BaseEntity<PK>
    {
        Task CreateAsync(T entity);
        Task UpdatedAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T?> GetByIdAsync(PK id);
        Task<IEnumerable<T>> GetAllAsync();
    }
}