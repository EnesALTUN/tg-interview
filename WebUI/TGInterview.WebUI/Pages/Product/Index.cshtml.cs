using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TGInterview.ApiRequestService.Abstract;
using TGInterview.WebUI.Models;
using TGInterview.WebUI.Models.Base;

namespace TGInterview.WebUI.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly IApiRequestService _apiRequestService;

        public IndexModel(IApiRequestService apiRequestService)
        {
            _apiRequestService = apiRequestService;
        }

        public void OnGet()
        {
        }

        public async Task<JsonResult> OnGetAllProducts()
        {
            var res = await _apiRequestService.ApiGetRequest<ApiResponse<List<ProductGetAllDto>>>("ProductServiceApi", "api/product");

            return new JsonResult(res);
        }
    }
}
