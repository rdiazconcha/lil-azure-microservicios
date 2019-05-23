FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Lil.Search/Lil.Search.csproj", "Lil.Search/"]
RUN dotnet restore "Lil.Search/Lil.Search.csproj"
COPY . .
WORKDIR "/src/Lil.Search"
RUN dotnet build "Lil.Search.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Lil.Search.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Lil.Search.dll"]
