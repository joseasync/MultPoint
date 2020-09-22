#source
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

#Copy csproj and restore 
COPY *.csproj ./
RUN dotnet restore

RUN pwsh -Command Write-Host "Simple MultPointer, generating a image and testing the PowerShellCore Updated"

#Build app
COPY . ./
RUN dotnet publish -c Release -o readyrelease

#Build image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/readyrelease .
ENTRYPOINT ["./MultPoint"]