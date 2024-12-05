using BurguerMania.Domain.Common;
using BurguerMania.Domain.Entities;

namespace BurguerMania.Domain.Interfaces
{
    public interface IOrderService : IService<IntKey, Order>
    {}
}