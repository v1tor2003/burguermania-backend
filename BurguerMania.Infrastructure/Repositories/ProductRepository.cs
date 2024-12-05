using BurguerMania.Domain.Common;
using BurguerMania.Domain.Entities;
using BurguerMania.Domain.Interfaces;
using BurguerMania.Infrastructure.Context;

namespace BurguerMania.Infrastructure.Repositories
{
    public class ProductRepository : BaseRepository<IntKey, Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context){ }
    }
}