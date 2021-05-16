FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
WORKDIR /src
COPY *.sln .
#COPY DemoHerokuTest/*.csproj DemoHerokuTest/
#RUN dotnet restore DemoHerokuTest/*.csproj
COPY ConsoleApp1/*.csproj ConsoleApp1/
RUN dotnet restore ConsoleApp1/*.csproj
COPY . .

#Testing
#FROM base AS testing
#WORKDIR /src/DemoHeroku
#RUN dotnet build
#WORKDIR /src/DemoHerokuTest
#RUN dotnet test

#Publishing
FROM base AS publish
WORKDIR /src/ConsoleApp1
RUN dotnet publish -c Release -o /src/publish

#Get the runtime into a folder called app
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime
WORKDIR /app
#COPY --from=build /app/Groundforce.Services.API/gforce.db .
COPY --from=publish /src/publish .
#ENTRYPOINT ["ConsoleApp1.exe"]
ENTRYPOINT ["dotnet", "ConsoleApp1.dll"]
#CMD ASPNETCORE_URLS=http://*:$PORT dotnet DemoHeroku.dll