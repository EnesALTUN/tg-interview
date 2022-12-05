using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Text;
using TGInterview.ApiRequestService.Abstract;

namespace TGInterview.ApiRequestService.Concrete;

public class ApiRequestService : IApiRequestService
{
    private readonly IHttpClientFactory httpClientFactory;

    public ApiRequestService(IHttpClientFactory httpClientFactory)
    {
        this.httpClientFactory = httpClientFactory;
    }

    public async Task<U?> ApiPostRequest<T, U>(string clientName, string url, T model, [Optional] Dictionary<string, string> headers)
    {
        var httpClient = httpClientFactory.CreateClient(clientName);

        if (headers.Any())
        {
            foreach (var header in headers)
                httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
        }

        var jsonModel = JsonConvert.SerializeObject(model);

        StringContent content = new(jsonModel, Encoding.UTF8, "application/json");

        var requestResult = await httpClient.PostAsync(url, content);

        if (requestResult.IsSuccessStatusCode == false)
            throw new Exception(requestResult.ReasonPhrase);

        string jsonContent = await requestResult.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<U>(jsonContent);
    }

    public async Task<T?> ApiGetRequest<T>(string clientName, string url)
    {
        var httpClient = httpClientFactory.CreateClient(clientName);

        var requestResult = await httpClient.GetAsync(url);

        if (requestResult.IsSuccessStatusCode == false)
            throw new Exception(requestResult.ReasonPhrase);

        string jsonContent = await requestResult.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<T>(jsonContent);
    }

}