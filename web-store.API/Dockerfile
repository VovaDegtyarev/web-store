#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["web-store.API/web-store.API.csproj", "web-store.API/"]
RUN dotnet restore "web-store.API/web-store.API.csproj"
COPY . .
WORKDIR "/src/web-store.API"
RUN dotnet build "web-store.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "web-store.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "web-store.API.dll"]