FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /stag
COPY StagApi.csproj .
RUN dotnet restore StagApi.csproj

FROM build AS publish
COPY . .
RUN dotnet build "StagApi.csproj" -c Debug -o /app/build

FROM base AS final
WORKDIR /app
COPY --from=publish /app/build/ .
ENTRYPOINT ["dotnet", "StagApi.dll"]