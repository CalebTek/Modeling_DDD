using Domain.Customers;
using Domain.Orders;
using Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Persistence
{
    internal interface IApplicationDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<LineItem> LineItems { get; set; }

        public DbSet<OrderSummary> OrderSummaries { get; set; }

        DatabaseFacade Database {  get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
