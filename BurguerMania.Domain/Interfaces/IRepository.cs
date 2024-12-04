using BurguerMania.Domain.Common;

namespace BurguerMania.Domain.Interfaces
{
    public interface IRepository<PK, T> where T : BaseEntity<PK>
    {
        Task CreateAsync();
        Task UpdateAsync();
        Task DeleteAsync();
        Task <T?> GetByIdAsync(PK id);
        Task <IEnumerable<T>> GetAllAsync();
        Task SaveAsync();
    }
}