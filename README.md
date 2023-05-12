# diary
## _back part_

Diary: a _simple_ calendar with notes.

Developing, buildind and deploying _progress_ run on `Linux` platform.

More _accurately_ `Linux Debian 11` with installed `dotnet 7.0` packages.

### api map

- `/healthcheck` - check application health.
- `/api/diary/empty` - test api.
- _todo_

## docker

Deploy and building process may be have __two__ variant:
A. Deployment system (gitlab, github,..) have `.Net` environment (SDK) for build project.
B. Deployment system NOT have `.Net` environment (SDK).

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

In this variant `Dockerfile` other: inside building and publishing process.

#### docker compose: build, deploy

1. Use Solution dirictory (root directory)
2. For build run command: `docker-compose build`
3. For run command: `docker-compose -f docker-compose.1.yml up -d`
4. For stop container run command: `docker-compose down`
