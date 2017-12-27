FROM microsoft/dotnet:2.0.4-runtime-nanoserver-1709 AS base

WORKDIR /app
COPY /bin/Debug/netcoreapp2.0/publish/ .

ENTRYPOINT ["dotnet", "DockerConsoleTestApp.dll"]

#docker build -t sanjay .
#docker run --name sanjay-c sanjay
#docker rm sanjay-c
#docker rmi sanjay
