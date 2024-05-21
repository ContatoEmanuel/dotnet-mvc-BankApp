# Use a imagem base do ASP.NET Core
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Use a imagem do SDK do .NET para construir o aplicativo
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copie o arquivo .csproj e restaure as dependências
COPY ["BankApp.csproj", "./"]
RUN dotnet restore "BankApp.csproj"

# Copie todo o código do projeto e compile
COPY . .
RUN dotnet build "BankApp.csproj" -c Release -o /app/build

# Publicar o aplicativo
FROM build AS publish
RUN dotnet publish "BankApp.csproj" -c Release -o /app/publish

# Configurar o contêiner final para executar o aplicativo
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BankApp.dll"]
