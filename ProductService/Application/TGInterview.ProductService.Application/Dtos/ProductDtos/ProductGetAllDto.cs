namespace TGInterview.ProductService.Application.Dtos.ProductDtos;

public class ProductGetAllDto
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public string ImagePath { get; set; }

    public string CategoryName { get; set; }
}