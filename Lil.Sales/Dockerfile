FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["lil.sales/Lil.Sales.csproj", "lil.sales/"]
RUN dotnet restore "lil.sales/Lil.Sales.csproj"
COPY . .
WORKDIR "/src/lil.sales"
RUN dotnet build "Lil.Sales.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Lil.Sales.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Lil.Sales.dll"]
