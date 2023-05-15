# https://hub.docker.com/_/microsoft-dotnet
# build on SDK
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS sdk70
WORKDIR /src

# current dir - dir, where placed Dockerfile
COPY ["./", "./Diary.Api"]
RUN ls -lha

RUN dotnet publish "./Diary.Api/Diary.Api.csproj" -c Release -o /app

# run on AspNet
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app

COPY --from=sdk70 /app ./
ENTRYPOINT ["dotnet", "Diary.Api.dll"]
