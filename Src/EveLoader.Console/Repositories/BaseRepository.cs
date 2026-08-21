using EveLoader.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace EveLoader.Repositories;

    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly EveDbContext _dbContext;

        public BaseRepository(EveDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

    public async Task<List<T>> AddRangeAsync(List<T> entities)
    {
        await _dbContext.Set<T>().AddRangeAsync(entities);
        await _dbContext.SaveChangesAsync();

        return entities;
    }

    public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }

