using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TGInterview.ProductService.Api.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name" },
                values: new object[] { new Guid("4923846e-08dd-4300-9d65-08b0d35e7f79"), new DateTime(2022, 12, 8, 16, 15, 35, 727, DateTimeKind.Utc).AddTicks(2943), null, true, null, "Laptop" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "ImagePath", "IsActive", "ModifiedDate", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("2942ae60-7848-4340-af62-2bc25a5ef4a9"), new Guid("4923846e-08dd-4300-9d65-08b0d35e7f79"), new DateTime(2022, 12, 8, 16, 15, 35, 727, DateTimeKind.Utc).AddTicks(3557), null, "https://productimages.hepsiburada.net/s/67/550/110000008473669.jpg/format:webp", true, null, "Lenovo ThinkPad E15 Gen 2 Intel Core i7 1165G7 32GB 1TB SSD MX450 Windows 10 Pro 15.6\" FHD Taşınabilir Bilgisayar 20TDF01J00A20", 24499.99m },
                    { new Guid("39ee5ede-a044-4bf2-9fd9-d85a54014285"), new Guid("4923846e-08dd-4300-9d65-08b0d35e7f79"), new DateTime(2022, 12, 8, 16, 15, 35, 727, DateTimeKind.Utc).AddTicks(3562), null, "https://productimages.hepsiburada.net/s/206/550/110000182831041.jpg/format:webp", true, null, "Hometech Alfa 470C Intel Celeron N4020 4GB 128GB SSD Windows 10 Home 14.1\" Hd Gold Taşınabilir Bilgisayar", 3699.00m },
                    { new Guid("43895cbf-526b-4277-8a1b-0d53ff5d9f55"), new Guid("4923846e-08dd-4300-9d65-08b0d35e7f79"), new DateTime(2022, 12, 8, 16, 15, 35, 727, DateTimeKind.Utc).AddTicks(3555), null, "https://productimages.hepsiburada.net/s/174/550/110000137999718.jpg/format:webp", true, null, "Asus X509FA-BR951T Intel Core i3 10110U 4GB 256GB SSD Windows 10 Home 15.6\" HD Taşınabilir Bilgisayar", 7979.00m },
                    { new Guid("a2e19377-ebea-41de-9c8c-5b5083ed884a"), new Guid("4923846e-08dd-4300-9d65-08b0d35e7f79"), new DateTime(2022, 12, 8, 16, 15, 35, 727, DateTimeKind.Utc).AddTicks(3552), null, "https://productimages.hepsiburada.net/s/268/550/110000253796405.jpg/format:webp", true, null, "Lenovo V14 ITL Gen2 Intel Core i5 1135G7 8GB 512GB SSD Windows 10 Home 14\" FHD Taşınabilir Bilgisayar 82KA0027TX", 10999.00m },
                    { new Guid("c2ac0654-011c-49f4-a52d-c7a64c6c6b84"), new Guid("4923846e-08dd-4300-9d65-08b0d35e7f79"), new DateTime(2022, 12, 8, 16, 15, 35, 727, DateTimeKind.Utc).AddTicks(3560), null, "https://productimages.hepsiburada.net/s/136/550/110000088054418.jpg/format:webp", true, null, "Hometech Alfa 470C Intel Celeron N4020 4GB 128GB SSD Windows 10 Home 14.1\" HD Taşınabilir Bilgisayar", 3649.00m },
                    { new Guid("c4b67628-53de-4123-987e-dfb606dc5f19"), new Guid("4923846e-08dd-4300-9d65-08b0d35e7f79"), new DateTime(2022, 12, 8, 16, 15, 35, 727, DateTimeKind.Utc).AddTicks(3567), null, "https://productimages.hepsiburada.net/s/54/550/11196750659634.jpg/format:webp", true, null, "i-Life Zed Air CX5 Intel Core i5 5257U 8GB 256GB SSD Windows 10 Home 15.6\" FHD Taşınabilir Bilgisayar NTBTILWBi5158256", 6699.00m },
                    { new Guid("c88a64e4-b9e0-469a-9250-12727b26ad94"), new Guid("4923846e-08dd-4300-9d65-08b0d35e7f79"), new DateTime(2022, 12, 8, 16, 15, 35, 727, DateTimeKind.Utc).AddTicks(3545), null, "https://productimages.hepsiburada.net/s/251/444-444/110000233748628.jpg", true, null, "Lenovo V15 Intel Core i5 10210U 8GB 512GB SSD MX330 15.6\" FHD Windows 10 Home Taşınabilir Bilgisayar 82NB003GTX", 11999.00m },
                    { new Guid("d959b7bc-1e34-4af2-831d-ca8f68f6e0d9"), new Guid("4923846e-08dd-4300-9d65-08b0d35e7f79"), new DateTime(2022, 12, 8, 16, 15, 35, 727, DateTimeKind.Utc).AddTicks(3564), null, "https://productimages.hepsiburada.net/s/43/550/10788533862450.jpg/format:webp", true, null, "Lenovo V14 IlL Intel Core i5 1035G1 8GB 256GB SSD Windows 10 Home 14\" FHD Taşınabilir Bilgisayar 82C400A8TX", 9584.55m },
                    { new Guid("eb03d02b-455d-4005-8120-8f4158e0f5cb"), new Guid("4923846e-08dd-4300-9d65-08b0d35e7f79"), new DateTime(2022, 12, 8, 16, 15, 35, 727, DateTimeKind.Utc).AddTicks(3549), null, "https://productimages.hepsiburada.net/s/155/550/110000111868185.jpg/format:webp", true, null, "Lenovo V15 G2 Itl Intel Core i5 1135G7 8GB 512GB SSD Windows 10 Home 15.6\" FHD Taşınabilir Bilgisayar 82KB00HUTX", 11999.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
