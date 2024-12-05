using AutoMapper;
using BurguerMania.Domain.Common;
using BurguerMania.Domain.Entities;
using BurguerMania.Domain.Interfaces;

namespace BurguerMania.Application.Services
{
    public class OrderService : BaseService<IntKey, Order>, IOrderService
    {
        public OrderService(IOrderRepository repository, IMapper mapper) : base(repository, mapper)
        {}

    }
}