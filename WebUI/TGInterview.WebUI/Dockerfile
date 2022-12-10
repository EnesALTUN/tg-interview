FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80

COPY Library/TGInterview.ApiRequestService/*.csproj ./Library/TGInterview.ApiRequestService/
COPY WebUI/TGInterview.WebUI/*.csproj ./WebUI/TGInterview.WebUI/

COPY ./*.sln .

RUN dotnet restore WebUI/TGInterview.WebUI/*.csproj
COPY . .
RUN dotnet publish WebUI/TGInterview.WebUI/*.csproj -o /publish/

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "TGInterview.WebUI.dll"]