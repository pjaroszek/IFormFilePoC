FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY Directory.Packages.props Directory.Packages.props
COPY Jaroszek.CoderHouse.IFormFilePoC.sln Jaroszek.CoderHouse.IFormFilePoC.sln
COPY Domain/Jaroszek.CoderHouse.IFormFilePoC.Domain.csproj Domain/Jaroszek.CoderHouse.IFormFilePoC.Domain.csproj
COPY Application/Jaroszek.CoderHouse.IFormFilePoC.Application.csproj Application/Jaroszek.CoderHouse.IFormFilePoC.Application.csproj
COPY Infrastructure/Jaroszek.CoderHouse.IFormFilePoC.Infrastructure.csproj Infrastructure/Jaroszek.CoderHouse.IFormFilePoC.Infrastructure.csproj
COPY WebUI/Jaroszek.CoderHouse.IFormFilePoC.WebApi.csproj WebUI/Jaroszek.CoderHouse.IFormFilePoC.WebApi.csproj


RUN dotnet restore

COPY . .

RUN dotnet build --configuration Release --output /app/build
RUN dotnet publish --configuration Release --output /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

RUN apt-get update && apt-get install -y net-tools iputils-ping telnet

COPY --from=build /app/publish .

RUN groupadd -g 10000 dotnet && useradd -u 10000 -g dotnet dotnet && chown -R dotnet:dotnet /app
USER dotnet:dotnet

ENV ASPNETCORE_URLS http://+:5056
EXPOSE 5056
ENTRYPOINT [ "dotnet", "Jaroszek.CoderHouse.IFormFilePoC.WebApi.dll"]
