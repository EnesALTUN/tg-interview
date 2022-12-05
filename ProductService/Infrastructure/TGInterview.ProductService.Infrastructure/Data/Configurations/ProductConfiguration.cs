using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TGInterview.ProductService.Domain.Entities;

namespace TGInterview.ProductService.Infrastructure.Data.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(x => x.Price)
            .HasPrecision(18, 2);

        builder.HasData(
            new Product
            {
                Id = Guid.Parse("c88a64e4-b9e0-469a-9250-12727b26ad94"),
                Name = "Lenovo V15 Intel Core i5 10210U 8GB 512GB SSD MX330 15.6\" FHD Windows 10 Home Taşınabilir Bilgisayar 82NB003GTX",
                Price = 11999.00M,
                ImagePath = "https://productimages.hepsiburada.net/s/251/444-444/110000233748628.jpg",
                IsActive = true,
                CategoryId = Guid.Parse("4923846e-08dd-4300-9d65-08b0d35e7f79"),
                CreatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.Parse("eb03d02b-455d-4005-8120-8f4158e0f5cb"),
                Name = "Lenovo V15 G2 Itl Intel Core i5 1135G7 8GB 512GB SSD Windows 10 Home 15.6\" FHD Taşınabilir Bilgisayar 82KB00HUTX",
                Price = 11999.00M,
                ImagePath = "https://productimages.hepsiburada.net/s/155/550/110000111868185.jpg/format:webp",
                IsActive = true,
                CategoryId = Guid.Parse("4923846e-08dd-4300-9d65-08b0d35e7f79"),
                CreatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.Parse("a2e19377-ebea-41de-9c8c-5b5083ed884a"),
                Name = "Lenovo V14 ITL Gen2 Intel Core i5 1135G7 8GB 512GB SSD Windows 10 Home 14\" FHD Taşınabilir Bilgisayar 82KA0027TX",
                Price = 10999.00M,
                ImagePath = "https://productimages.hepsiburada.net/s/268/550/110000253796405.jpg/format:webp",
                IsActive = true,
                CategoryId = Guid.Parse("4923846e-08dd-4300-9d65-08b0d35e7f79"),
                CreatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.Parse("43895cbf-526b-4277-8a1b-0d53ff5d9f55"),
                Name = "Asus X509FA-BR951T Intel Core i3 10110U 4GB 256GB SSD Windows 10 Home 15.6\" HD Taşınabilir Bilgisayar",
                Price = 7979.00M,
                ImagePath = "https://productimages.hepsiburada.net/s/174/550/110000137999718.jpg/format:webp",
                IsActive = true,
                CategoryId = Guid.Parse("4923846e-08dd-4300-9d65-08b0d35e7f79"),
                CreatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.Parse("2942ae60-7848-4340-af62-2bc25a5ef4a9"),
                Name = "Lenovo ThinkPad E15 Gen 2 Intel Core i7 1165G7 32GB 1TB SSD MX450 Windows 10 Pro 15.6\" FHD Taşınabilir Bilgisayar 20TDF01J00A20",
                Price = 24499.99M,
                ImagePath = "https://productimages.hepsiburada.net/s/67/550/110000008473669.jpg/format:webp",
                IsActive = true,
                CategoryId = Guid.Parse("4923846e-08dd-4300-9d65-08b0d35e7f79"),
                CreatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.Parse("c2ac0654-011c-49f4-a52d-c7a64c6c6b84"),
                Name = "Hometech Alfa 470C Intel Celeron N4020 4GB 128GB SSD Windows 10 Home 14.1\" HD Taşınabilir Bilgisayar",
                Price = 3649.00M,
                ImagePath = "https://productimages.hepsiburada.net/s/136/550/110000088054418.jpg/format:webp",
                IsActive = true,
                CategoryId = Guid.Parse("4923846e-08dd-4300-9d65-08b0d35e7f79"),
                CreatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.Parse("39ee5ede-a044-4bf2-9fd9-d85a54014285"),
                Name = "Hometech Alfa 470C Intel Celeron N4020 4GB 128GB SSD Windows 10 Home 14.1\" Hd Gold Taşınabilir Bilgisayar",
                Price = 3699.00M,
                ImagePath = "https://productimages.hepsiburada.net/s/206/550/110000182831041.jpg/format:webp",
                IsActive = true,
                CategoryId = Guid.Parse("4923846e-08dd-4300-9d65-08b0d35e7f79"),
                CreatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.Parse("d959b7bc-1e34-4af2-831d-ca8f68f6e0d9"),
                Name = "Lenovo V14 IlL Intel Core i5 1035G1 8GB 256GB SSD Windows 10 Home 14\" FHD Taşınabilir Bilgisayar 82C400A8TX",
                Price = 9584.55M,
                ImagePath = "https://productimages.hepsiburada.net/s/43/550/10788533862450.jpg/format:webp",
                IsActive = true,
                CategoryId = Guid.Parse("4923846e-08dd-4300-9d65-08b0d35e7f79"),
                CreatedDate = DateTime.UtcNow
            },
            new Product
            {
                Id = Guid.Parse("c4b67628-53de-4123-987e-dfb606dc5f19"),
                Name = "i-Life Zed Air CX5 Intel Core i5 5257U 8GB 256GB SSD Windows 10 Home 15.6\" FHD Taşınabilir Bilgisayar NTBTILWBi5158256",
                Price = 6699.00M,
                ImagePath = "https://productimages.hepsiburada.net/s/54/550/11196750659634.jpg/format:webp",
                IsActive = true,
                CategoryId = Guid.Parse("4923846e-08dd-4300-9d65-08b0d35e7f79"),
                CreatedDate = DateTime.UtcNow
            }
        );
    }
}