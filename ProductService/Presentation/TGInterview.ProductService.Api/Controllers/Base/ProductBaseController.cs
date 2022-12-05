using Microsoft.AspNetCore.Mvc;
using TGInterview.Core.Wrappers;

namespace TGInterview.ProductService.Api.Controllers.Base;

public class ProductBaseController : ControllerBase
{
    public IActionResult ActionResultInstance<TData>(ApiResponse<TData> response) where TData : class
    {
        return new ObjectResult(response)
        {
            StatusCode = response.StatusCode
        };
    }
}