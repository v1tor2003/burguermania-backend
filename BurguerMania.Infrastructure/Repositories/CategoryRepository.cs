using BurguerMania.Domain.Common;
using BurguerMania.Domain.Entities;
using BurguerMania.Domain.Interfaces;
using BurguerMania.Infrastructure.Context;

namespace BurguerMania.Infrastructure.Repositories
{
    public class CategoryRepository : BaseRepository<IntKey, Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context){ }
    }
}