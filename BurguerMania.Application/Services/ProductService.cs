using AutoMapper;
using BurguerMania.Domain.Common;
using BurguerMania.Domain.Entities;
using BurguerMania.Domain.Interfaces;

namespace BurguerMania.Application.Services
{
    public class ProductService : BaseService<IntKey, Product>, IProductService
    {
        public ProductService(IProductRepository repository, IMapper mapper) 
        : base(repository, mapper)
        {}

        public async Task<TRes?> GetByIdAsync<TRes>(int productId) where TRes : BaseDto
        {
            return await GetByIdAsync<TRes>(new IntKey(productId));
        }

    }
}