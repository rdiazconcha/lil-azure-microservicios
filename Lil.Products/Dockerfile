FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Lil.products/Lil.Products.csproj", "Lil.products/"]
RUN dotnet restore "Lil.products/Lil.Products.csproj"
COPY . .
WORKDIR "/src/Lil.products"
RUN dotnet build "Lil.Products.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Lil.Products.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Lil.Products.dll"]
