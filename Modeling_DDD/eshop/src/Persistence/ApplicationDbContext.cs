using Domain.Customers;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseNpgsql();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

        public DbSet<Customer> Customers { get; set; }

    }
}
