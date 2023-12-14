using CRMManager.Domain.Aggregates.CustomerAggregate;
using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRMManager.Infrastructure.Persistence.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                   .HasConversion(c => c.Value, value => CustomerId.Create(value)).ValueGeneratedOnAdd();
        }
    }
}
