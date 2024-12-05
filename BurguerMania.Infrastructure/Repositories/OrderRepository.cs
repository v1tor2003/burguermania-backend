using BurguerMania.Domain.Common;
using BurguerMania.Domain.Entities;
using BurguerMania.Domain.Interfaces;
using BurguerMania.Infrastructure.Context;

namespace BurguerMania.Infrastructure.Repositories
{
    public class OrderRepository : BaseRepository<IntKey, Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context){ }
    }
}