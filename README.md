# TGInterview
The backend of the frontend project uses the TGInterview.ApiRequestService project located under the Library folder to send requests to the related microservices. Json serialize and deserialize operations are done here. In the project (UI Backend) that wants to use ApiRequestService, first of all, DI registration in Singleton type must be done. Then the HttpClient needs to be added. These operations are:

```
builder.Services.AddSingleton<IApiRequestService, ApiRequestService>();
builder.Services.AddHttpClient("ProductServiceApi", options =>
{
    options.BaseAddress = new Uri(builder.Configuration.GetValue<string>("ProductServiceApiUrl"));
});
```

### Usage of ApiRequestService:
After the Constructor DI operation is done, the ApiGetRequest method is called to make a GET request. The related method expects which model to return as a GenericType as a result of the GET request. The method expects two parameters. These:
1) Client name
2) Endpoint Url without BaseUrl
```
private readonly IApiRequestService _apiRequestService;

public IndexModel(IApiRequestService apiRequestService)
{
    _apiRequestService = apiRequestService;
}

public async Task<JsonResult> OnGetAllProducts()
{
    var res = await _apiRequestService.ApiGetRequest<ApiResponse<List<ProductGetAllDto>>>("ProductServiceApi", "api/product");

    return new JsonResult(res);
}
```

## Used Technologies
- FluentValidation
- MediatR
- AutoMapper
- EntityFramework Core
- Swashbuckle

## Service Ports
| Service Name     | HTTPS Port  | HTTP Port |
| ---------------- | ----------- | --------- |
| WebUI            | 7120        | 5120      |
| Product Service  | 7020        | 5020      |

## Defining The ProductDbConnection Connection Clause In User-Secret
1) First, go to the API project on the command line. 
```
  TGInterview > ProductService > Presentation > TGInterview.ProductService.Api
```
2) Creating user-secrets
```
  dotnet user-secrets init
```
3) Setted user-secrets
```
  dotnet user-secrets set ProductSqlConnection "Data Source=<IP Number or locahost>,<PORT_NUMBER>;Initial Catalog=<DB_NAME>;User Id=<DB_USERNAME>;Password=<DB_PASSWORD>;Integrated Security=False"
```

## Product Service Migration
Before the product service can run, the database must be created. For this process, we need to create a migration. Since seed data is defined in EntityFramework configurations, the database will be created full. You can follow the steps below to create a migration:

1) First, go to the API project on the command line. 
```
  TGInterview > ProductService > Presentation > TGInterview.ProductService.Api
```
2) The migration creation command is written and the custom context file (ProductDbContext) is defined with the --context parameter.
```
  dotnet ef migrations add <Migration Name> --context ProductDbContext
```
3) The created migration file is processed to the database.
```
  dotnet ef database update
```
