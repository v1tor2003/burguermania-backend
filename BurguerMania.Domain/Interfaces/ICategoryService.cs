using BurguerMania.Domain.Common;
using BurguerMania.Domain.Entities;

namespace BurguerMania.Domain.Interfaces
{
    public interface ICategoryService : IService<IntKey, Category>
    {
        Task<IEnumerable<Product>> GetProductsAsync(int categoryId);
        Task<IEnumerable<TRes>> GetProductsAsync<TRes>(int categoryId) where TRes : BaseDto;
    }
}