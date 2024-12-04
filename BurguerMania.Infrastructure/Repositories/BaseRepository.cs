using BurguerMania.Domain.Common;
using BurguerMania.Domain.Interfaces;
using BurguerMania.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BurguerMania.Infrastructure.Repositories
{
    public class BaseRepository<PK, T> : IRepository<PK, T> 
        where PK: IEntityKey
        where T : BaseEntity<PK>
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context) => 
            _context = context;
        public async Task CreateAsync(T entity)
        {
            await _context.AddAsync(entity);
        }
        public Task UpdateAsync(T entity)
        {
            entity.UpdatedAt = DateTimeOffset.UtcNow;
            _context.Update(entity);
            return Task.CompletedTask;
        }
        public Task DeleteAsync(T entity)
        {
            _context.Remove(entity);
            return Task.CompletedTask;
        }
        public async Task<T?> GetByIdAsync(PK id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(e => e.Id.Equals(id));
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
        public async Task SaveAsync() => await _context.SaveChangesAsync();
    }
}