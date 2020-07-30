using IdentityService.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IdentityService.Data.GenericRepository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);
        Task<T> FindAsync(Expression<Func<T, bool>> match);

        Task<ICollection<T>> FindByAsync(Expression<Func<T, bool>> predicate);
        Task<ICollection<T>> GetAllAsync();
        Task<T> GetAsync(long id);

        void Dispose();
    }
}
