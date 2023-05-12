# diary
## _back part_

Diary: a simple calendar with notes.

Developing, buildind and deploying _progress_ run on `Linux` platform.

More _accurately_ `Linux Debian 11` with installed `dotnet 7.0` packages.

### api map

- `/healthcheck` - check application health.
- `/api/diary/empty` - test api.

### docker: build

1. Build manually. In each Project need run command: `dotnet publish -c Release -o published`
2. `Dockerfile` ready to build image.
3. Tested run project: `dotnet run -lp prod published/Diary.Api.dll`

### docker compose: build, deploy

1. `docker-compose.yml` file located in Solution dirictory (root directory)
2. For build run command: `docker-compose build`
3. For run command: `docker-compose up -d`

