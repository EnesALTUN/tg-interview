using TGInterview.Core.Base.Abstract;
using TGInterview.Core.Base.Concrete;

namespace TGInterview.ProductService.Domain.Entities;

public class Product : BaseEntity, IEntity
{
    public string Name { get; set; }

    public decimal Price { get; set; }

    public string ImagePath { get; set; }

    public Guid CategoryId { get; set; }

    public Category Category { get; set; }
}