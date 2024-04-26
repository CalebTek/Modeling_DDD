using Domain.Orders;
using Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    internal class LineItemConfiguration : IEntityTypeConfiguration<LIneItem>
    {
        public void Configure(EntityTypeBuilder<LIneItem> builder)
        {
           builder.HasKey(li => li.Id);

            builder.Property(li => li.Id).HasConversion(
                lineItemId => lineItemId.Value, 
                value => new LIneItemId(value));

            builder.HasOne<Product>()
                .WithMany().HasForeignKey(li => li.ProductId);

            builder.OwnsOne(li => li.Price);
        }
    }
}
