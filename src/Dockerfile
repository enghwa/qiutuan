FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

COPY ./ .
WORKDIR /app/FargateDemo.Web.Host
RUN dotnet restore

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=build-env /app/FargateDemo.Web.Host/out .
ENTRYPOINT ["dotnet", "FargateDemo.Web.Host.dll"]
