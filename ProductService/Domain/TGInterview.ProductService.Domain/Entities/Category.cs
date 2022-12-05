using TGInterview.Core.Base.Abstract;
using TGInterview.Core.Base.Concrete;

namespace TGInterview.ProductService.Domain.Entities;

public class Category : BaseEntity, IEntity
{
    public string Name { get; set; }
}