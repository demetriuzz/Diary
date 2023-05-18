# diary

Diary: a _simple_ calendar with notes (**backend** part).

Developing, buildind and deploying _progress_ run on `Linux` platform.

More _accurately_ `Linux Debian 11` with installed `dotnet 7.0` packages.

## api map

- `/healthcheck` - check application health.
- OpenAPI http://localhost:5168/swagger or https://localhost:7120/swagger

## docker

Deploy and building process may be have __two__ variant:

- **A**: Deployment system (gitlab, github,..) have `.Net` environment (SDK) for build project.
- **B**: Deployment system NOT have `.Net` environment (SDK).

### A: manually build

If deployment system have `.Net` environment (SDK), then we can run publish command, and skeep building process in Docker container.

`Dockerfile` name is `Dockerfile.1` for this variant (as addition).
For `docker-compose` file have name `docker-compose.1.yml`.
Why?
Because it is an _optional_ extra.

#### docker: build

1. Build manually. In each Project need run command: `dotnet publish -c Release -o published`
2. `Dockerfile.1` ready to build image.
3. Tested run project: `dotnet run -lp prod published/Diary.Api.dll`

#### docker compose: build, deploy

1. `docker-compose.1.yml` file located in Solution dirictory (root directory)
2. For build run command: `docker-compose -f docker-compose.1.yml build`
3. For run command: `docker-compose -f docker-compose.1.yml up -d`
4. For stop container run command: `docker-compose -f docker-compose.1.yml down`

### B: build in container

If deployment system NOT have `.Net` environment (SDK), then need buildind and deployment process inside container.

In this variant `Dockerfile` _other_: inside building and publishing process.

#### docker compose: build, deploy

1. Use Solution dirictory (root directory)
2. For build run command: `docker-compose build`
3. For run command: `docker-compose -f docker-compose.1.yml up -d`
4. For stop container run command: `docker-compose down`

## database

For work with database used `EntityFrameworkCore` and database provider packages.

Used database context and migrations.

For migrations need package `dotnet-ef` from `dotnet tool` installed _locally_ in project.

Wny _locally_? For automating migration process in `Docker` container.

### install dotnet-ef

Solution contain projects with name `Diary.Persistence.<NAME>` where `<NAME>` type database provider: `SQLite`, `Postgres` and etc.

In each such project exist directory `Migrations` where migration files are located: this is _defaults_ directory for created migration files.

In root solution directory exist file `.config/dotnet-tools.json` with information about installed tools.

After _first_ cloning `git` repository need __restore__ dotnet tool.

### using dotnet-ef

Command `dotnet dotnet-ef` run from solution root directory _(and root directory in Docker building container)_.
Output `Log level` set when `DbContext` added in service list by `AddDbContext` method.

1. Migration list for `SQLite` provider:
`dotnet dotnet-ef migrations list -p Diary.Persistence.SQLite -s Diary.Api`
Database context _fined_ in selected project directory, option `-p`.

2. Initial - _first_ migration for `SQLite` provider:
`dotnet dotnet-ef migrations add InitialCreate -p Diary.Persistence.SQLite -s Diary.Api`
Created migration file have name by pattern `yyyyMMddhhmmss_InitialCreate.cs` where `yyyyMMddhhmmss` date and time in `UTC` time zone.
And also created snapshot file with name `SqliteDbContextModelSnapshot.cs`.

3. Using migration for database: `dotnet dotnet-ef database update -p Diary.Persistence.SQLite -s Diary.Api`
