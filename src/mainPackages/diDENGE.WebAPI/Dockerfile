FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/mainPackages/diDENGE.WebAPI/diDENGE.WebAPI.csproj", "src/mainPackages/diDENGE.WebAPI/"]
COPY ["src/mainPackages/diDENGE.Infrastructure/diDENGE.Infrastructure.csproj", "src/mainPackages/diDENGE.Infrastructure/"]
COPY ["src/mainPackages/diDENGE.Presentation/diDENGE.Presentation.csproj", "src/mainPackages/diDENGE.Presentation/"]
COPY ["src/mainPackages/diDENGE.Persistance/diDENGE.Persistance.csproj", "src/mainPackages/diDENGE.Persistance/"]
COPY ["src/corePackages/Core.Security/Core.Security.csproj", "src/corePackages/Core.Security/"]
COPY ["src/corePackages/Core.Persistence/Core.Persistence.csproj", "src/corePackages/Core.Persistence/"]
COPY ["src/mainPackages/diDENGE.Domain/diDENGE.Domain.csproj", "src/mainPackages/diDENGE.Domain/"]
COPY ["src/mainPackages/diDENGE.Application/diDENGE.Application.csproj", "src/mainPackages/diDENGE.Application/"]
COPY ["src/corePackages/Core.Application/Core.Application.csproj", "src/corePackages/Core.Application/"]
COPY ["src/corePackages/Core.CrossCuttingConcers/Core.CrossCuttingConcerns.csproj", "src/corePackages/Core.CrossCuttingConcers/"]
RUN dotnet restore "src/mainPackages/diDENGE.WebAPI/diDENGE.WebAPI.csproj"
COPY . .
WORKDIR "/src/src/mainPackages/diDENGE.WebAPI"
RUN dotnet build "diDENGE.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "diDENGE.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "diDENGE.WebAPI.dll"]
