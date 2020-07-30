using IdentityService.Data.Context.SqlServer.CodeFirst;
using IdentityService.Data.Entity;
using IdentityService.Data.GenericRepository;
using System;
using System.Threading.Tasks;

namespace IdentityService.Data.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IdentityDataContext context;
        public UnitOfWork(IdentityDataContext dbContext)
        {
            context = dbContext;
        }

        public IGenericRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new GenericRepository<T>(context);
        }

        public int SaveChanges()
        {
            try
            {
                return context.SaveChanges();
            }
            catch (Exception ex)
            {
                //TODO: Logging
                throw;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            try
            {
                return await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                //TODO: Logging
                throw;
            }
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
