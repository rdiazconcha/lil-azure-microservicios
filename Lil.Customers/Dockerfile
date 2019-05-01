FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Lil.Customers/Lil.Customers.csproj", "Lil.Customers/"]
RUN dotnet restore "Lil.Customers/Lil.Customers.csproj"
COPY . .
WORKDIR "/src/Lil.Customers"
RUN dotnet build "Lil.Customers.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Lil.Customers.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Lil.Customers.dll"]
