using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net;
using TGInterview.Core.Wrappers;
using TGInterview.ProductService.Application.Cqrs.Queries.ProductQueries;
using TGInterview.ProductService.Application.Dtos.ProductDtos;
using TGInterview.ProductService.Domain.Entities;
using TGInterview.ProductService.Infrastructure.Data.Context;
using TGInterview.ProductService.Infrastructure.UnitOfWork;

namespace TGInterview.ProductService.Application.Cqrs.QueryHandlers.ProductQueryHandlers;

public class GetProductAllQueryHandler : IRequestHandler<GetProductAllQuery, ApiResponse<List<ProductGetAllDto>>>
{
    private readonly IUnitOfWork<ProductDbContext> _unitOfWork;
    private readonly IMapper _mapper;

    public GetProductAllQueryHandler(IUnitOfWork<ProductDbContext> unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<ApiResponse<List<ProductGetAllDto>>> Handle(GetProductAllQuery request, CancellationToken cancellationToken)
    {
        var products = await _unitOfWork.GetRepository<Product>()
            .GetAll()
            .ProjectTo<ProductGetAllDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        return new ApiResponse<List<ProductGetAllDto>>
        {
            Data = _mapper.Map<List<ProductGetAllDto>>(products),
            StatusCode = (int)HttpStatusCode.OK,
            IsSuccessful = true,
            TotalItemCount = products.Count
        };
    }
}