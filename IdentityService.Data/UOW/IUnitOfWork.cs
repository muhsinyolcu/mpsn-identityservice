using IdentityService.Data.Entity;
using IdentityService.Data.GenericRepository;
using System;
using System.Threading.Tasks;

namespace IdentityService.Data.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : BaseEntity;
        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}
