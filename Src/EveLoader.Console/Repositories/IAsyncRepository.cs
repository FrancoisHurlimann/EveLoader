using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveLoader.Repositories;

public interface IAsyncRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task<List<T>> AddRangeAsync(List<T> entities);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
