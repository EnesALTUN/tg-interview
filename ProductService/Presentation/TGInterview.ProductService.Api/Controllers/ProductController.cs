using MediatR;
using Microsoft.AspNetCore.Mvc;
using TGInterview.ProductService.Api.Controllers.Base;
using TGInterview.ProductService.Application.Cqrs.Queries.ProductQueries;

namespace TGInterview.ProductService.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ProductBaseController
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProduct()
    {
        var result = await _mediator.Send(new GetProductAllQuery());

        return ActionResultInstance(result);
    }
}