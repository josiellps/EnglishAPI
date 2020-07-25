FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
 
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["EnglishAPI/EnglishAPI.csproj", "EnglishAPI/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Data/Data.csproj", "Data/"]
COPY ["Business/Business.csproj", "Business/"]
COPY ["Repository/Repository.csproj", "Repository/"]
RUN dotnet restore "EnglishAPI/EnglishAPI.csproj"

COPY . .
WORKDIR "/src/."
RUN dotnet build "EnglishAPI.csproj" -c Release -o /app/build
 
FROM build AS publish
RUN dotnet publish "EnglishAPI.csproj" -c Release -o /app/publish
 
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EnglishAPI.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet EnglishAPI.dll