# https://hub.docker.com/_/microsoft-dotnet
# 1. using SDK image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS sdk70
WORKDIR /src

# 2. copy projects (current dir set in docker-compose build context)
COPY ["Diary.Api", "Diary.Api"]
COPY ["Diary.Application", "Diary.Application"]
COPY ["Diary.Domain", "Diary.Domain"]
COPY ["Diary.Persistence", "Diary.Persistence"]
COPY ["Diary.Persistence.SQLite", "Diary.Persistence.SQLite"]

# 3. entity framework, db migration
COPY [".config", ".config"]
RUN dotnet tool restore
RUN dotnet tool list
RUN dotnet dotnet-ef database update -p Diary.Persistence.SQLite -s Diary.Api

# 4. dir status
RUN ls -lha

# 5. prepare running application
RUN dotnet publish "./Diary.Api/Diary.Api.csproj" -c Release -o /app
# 5.1 SQLite only!
COPY ["Diary.Api/diary.db", "/app/diary.db"]

RUN ls -lha /app

# 6. run on AspNet
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
# 6.1 copy all building result
COPY --from=sdk70 /app ./
ENTRYPOINT ["dotnet", "Diary.Api.dll"]
