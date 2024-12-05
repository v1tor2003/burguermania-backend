using BurguerMania.Domain.Common;
using BurguerMania.Domain.Entities;

namespace BurguerMania.Domain.Interfaces
{
    public interface IProductService : IService<IntKey, Product>
    { 
        Task<TRes?> GetByIdAsync<TRes>(int id) where TRes : BaseDto;
    }
}