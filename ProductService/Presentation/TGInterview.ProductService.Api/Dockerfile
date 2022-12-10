FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80

COPY Library/TGInterview.Core/*.csproj ./Library/TGInterview.Core/
COPY ProductService/Domain/TGInterview.ProductService.Domain/*.csproj ./ProductService/Domain/TGInterview.ProductService.Domain/
COPY ProductService/Infrastructure/TGInterview.ProductService.Infrastructure/*.csproj ./ProductService/Infrastructure/TGInterview.ProductService.Infrastructure/
COPY ProductService/Application/TGInterview.ProductService.Application/*.csproj ./ProductService/Application/TGInterview.ProductService.Application/
COPY ProductService/Presentation/TGInterview.ProductService.Api/*.csproj ./ProductService/Presentation/TGInterview.ProductService.Api/

COPY ./*.sln .

RUN dotnet restore ProductService/Presentation/TGInterview.ProductService.Api/*.csproj
COPY . .
RUN dotnet publish ProductService/Presentation/TGInterview.ProductService.Api/*.csproj -o /publish/

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "TGInterview.ProductService.Api.dll"]