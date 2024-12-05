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
        Task<TRes?> GetByIdAsync<TRes>(PK id) where TRes : BaseDto;
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<TRes>> GetAllAsync<TRes>() where TRes : BaseDto;
    }
}