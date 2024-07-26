FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source
COPY *.sln .
COPY medical-record-users-api/*.csproj ./medical-record-users-api/
COPY medical-record-users-api/. ./medical-record-users-api/
RUN dotnet restore
RUN dotnet publish -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .
EXPOSE 80
ENTRYPOINT ["dotnet", "Csharp.UsersApi.dll",  "--urls", "http://*:80"]