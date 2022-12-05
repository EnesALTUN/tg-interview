using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TGInterview.ProductService.Domain.Entities;

namespace TGInterview.ProductService.Infrastructure.Data.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
            new Category { Id = Guid.Parse("4923846e-08dd-4300-9d65-08b0d35e7f79"), Name = "Laptop", IsActive = true, CreatedDate = DateTime.UtcNow }
        );
    }
}