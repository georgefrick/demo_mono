FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MinimalCompanyAPI/MinimalCompanyAPI.csproj", "MinimalCompanyAPI/"]
RUN dotnet restore "MinimalCompanyAPI/MinimalCompanyAPI.csproj"
COPY . .
WORKDIR "/src/MinimalCompanyAPI"
RUN dotnet build "MinimalCompanyAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MinimalCompanyAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MinimalCompanyAPI.dll"]
