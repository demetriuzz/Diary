# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS sdk70
WORKDIR /src
COPY [".", "."]
# RUN ls -lha
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=sdk70 /app ./
ENTRYPOINT ["dotnet", "Diary.Api.dll"]
