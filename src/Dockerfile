FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

COPY ./ .
WORKDIR /app/FargateDemo.Web.Host
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine

WORKDIR /app
ADD FargateDemo.sh .
RUN chmod +x /app/FargateDemo.sh

COPY --from=build-env /app/FargateDemo.Web.Host/out .
EXPOSE 80
ENTRYPOINT ["/app/FargateDemo.sh"]
# ENTRYPOINT ["dotnet", "FargateDemo.Web.Host.dll"]
