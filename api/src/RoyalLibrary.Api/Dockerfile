#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["RoyalLibrary.Api/RoyalLibrary.Api.csproj", "RoyalLibrary.Api/"]
RUN dotnet restore "RoyalLibrary.Api/RoyalLibrary.Api.csproj"
COPY . .
WORKDIR "/src/RoyalLibrary.Api"
RUN dotnet build "RoyalLibrary.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RoyalLibrary.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RoyalLibrary.Api.dll"]