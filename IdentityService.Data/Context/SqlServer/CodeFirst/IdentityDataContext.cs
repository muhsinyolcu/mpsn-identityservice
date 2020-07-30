using IdentityService.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace IdentityService.Data.Context.SqlServer.CodeFirst
{
    public class IdentityDataContext : DbContext
    {
        //TODO
        protected readonly string connectionString = "";
        public IdentityDataContext(DbContextOptions<IdentityDataContext> options)
            : base(options)
        {

        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
