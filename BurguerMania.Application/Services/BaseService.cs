using AutoMapper;
using BurguerMania.Domain.Common;
using BurguerMania.Domain.Interfaces;

namespace BurguerMania.Application.Services
{
    public class BaseService<PK, T> : IService<PK, T> 
        where PK : IEntityKey
        where T : BaseEntity<PK>
    {
        protected readonly IRepository<PK, T> _repository;
        protected readonly IMapper _mapper;

        public BaseService(IRepository<PK, T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(T entity)
        {
            await _repository.CreateAsync(entity);
            await _repository.SaveAsync();
        }
        
        public async Task UpdatedAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            await _repository.DeleteAsync(entity);
            await _repository.SaveAsync();
        }
        
        public async Task<T?> GetByIdAsync(PK id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}