#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:5.0-buster AS build
WORKDIR /src
COPY ["src/SiteMercado.Api/SiteMercado.Api.csproj", "src/SiteMercado.Api/"]
RUN dotnet restore "src/SiteMercado.Api/SiteMercado.Api.csproj"
COPY . .
WORKDIR "/src/src/SiteMercado.Api"
RUN dotnet build "SiteMercado.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SiteMercado.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SiteMercado.Api.dll"]