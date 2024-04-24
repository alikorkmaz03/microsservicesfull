FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR  /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR  /app
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet","PlatformService.dll" ]

# docker build -t alikorkmaz03/platformservice .
# docker push alikorkmaz03/platformservice
# docker run -p 8080:80 -d alikorkmaz03/platformservice ->docker run on 8080:80  ports
#docker ps -> list for docker container 