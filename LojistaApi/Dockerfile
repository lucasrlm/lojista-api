FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["LojistaApi.csproj", ""]
RUN dotnet restore "./LojistaApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "LojistaApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LojistaApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LojistaApi.dll"]