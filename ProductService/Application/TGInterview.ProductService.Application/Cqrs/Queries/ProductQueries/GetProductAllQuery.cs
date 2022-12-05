using MediatR;
using TGInterview.Core.Wrappers;
using TGInterview.ProductService.Application.Dtos.ProductDtos;

namespace TGInterview.ProductService.Application.Cqrs.Queries.ProductQueries;

public class GetProductAllQuery : IRequest<ApiResponse<List<ProductGetAllDto>>>
{
}