FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Prestamos.API/Prestamos.API.csproj", "Prestamos.API/"]
COPY ["Prestamos.Infrastructure/Prestamos.Infrastructure.csproj", "Prestamos.Infrastructure/"]
COPY ["Prestamos.Domain/Prestamos.Domain.csproj", "Prestamos.Domain/"]
RUN dotnet restore "Prestamos.API/Prestamos.API.csproj"
COPY . .
WORKDIR "/src/Prestamos.API"
RUN dotnet build "Prestamos.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Prestamos.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Prestamos.API.dll"]