#BUILD PHASE
FROM microsoft/aspnetcore-build:2.0.4-2.1.3-nanoserver-1709 AS build-env
WORKDIR /app
COPY *.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o out

#RUN PHASE
FROM microsoft/aspnetcore:2.0.4-nanoserver-1709
WORKDIR /app
COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "DockerWebTestApp.dll"]

#docker build -t sanjay-quotes .
#docker run -d --name sanjay-quotes-c sanjay-quotes
#docker inspect sanjay-quotes-c
#docker stop sanjay-quotes-c
#docker start sanjay-quotes-c
#docker logs sanjay-quotes-c
#docker rm sanjay-quotes-c
#docker rmi sanjay-quotes