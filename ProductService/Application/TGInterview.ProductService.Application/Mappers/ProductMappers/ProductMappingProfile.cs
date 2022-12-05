using AutoMapper;
using TGInterview.ProductService.Application.Dtos.ProductDtos;
using TGInterview.ProductService.Domain.Entities;

namespace TGInterview.ProductService.Application.Mappers.ProductMappers;

public class ProductMappingProfile : Profile
{
	public ProductMappingProfile()
	{
		CreateMap<Product, ProductGetAllDto>()
			.ForMember(x => x.CategoryName, y => y.MapFrom(z => z.Category.Name));
	}
}