using AutoMapper;
using BurguerMania.Domain.Common;
using BurguerMania.Domain.Entities;
using BurguerMania.Domain.Interfaces;

namespace BurguerMania.Application.Services
{
    public class CategoryService : BaseService<IntKey, Category>, ICategoryService
    {
        public CategoryService(ICategoryRepository repository, IMapper mapper) 
        : base(repository, mapper)
        {}

        public async Task<IEnumerable<Product>> GetProductsAsync(int categoryId)
        {
            var category = await _repository.GetByIdAsync(new IntKey(categoryId), c => c.Products);
            if(category is null) return [];

            return category.Products;
        }

        public async Task<IEnumerable<TRes>> GetProductsAsync<TRes>(int categoryId) where TRes : BaseDto
        {
            var products = await GetProductsAsync(categoryId);
            
            return products.Select(_mapper.Map<TRes>);
        }
    }
}