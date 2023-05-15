# https://hub.docker.com/_/microsoft-dotnet
# build on SDK
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS sdk70
WORKDIR /src

# current dir set in docker-compose build context
COPY ["Diary.Api", "Diary.Api"]
COPY ["Diary.Application", "Diary.Application"]
COPY ["Diary.Domain", "Diary.Domain"]
RUN ls -lha

RUN dotnet publish "./Diary.Api/Diary.Api.csproj" -c Release -o /app

# run on AspNet
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app

COPY --from=sdk70 /app ./
ENTRYPOINT ["dotnet", "Diary.Api.dll"]
