using System.Runtime.InteropServices;

namespace TGInterview.ApiRequestService.Abstract;

public interface IApiRequestService
{
    Task<U?> ApiPostRequest<T, U>(string clientName, string url, T model, [Optional] Dictionary<string, string> headers);

    Task<T?> ApiGetRequest<T>(string clientName, string url);
}