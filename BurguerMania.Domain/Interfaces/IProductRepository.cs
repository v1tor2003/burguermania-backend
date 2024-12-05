using BurguerMania.Domain.Common;
using BurguerMania.Domain.Entities;

namespace BurguerMania.Domain.Interfaces
{
    public interface IProductRepository : IRepository<IntKey, Product> { }
}