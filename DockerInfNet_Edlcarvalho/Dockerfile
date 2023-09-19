#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DockerInfNet_Edlcarvalho/DockerInfNet_Edlcarvalho.csproj", "DockerInfNet_Edlcarvalho/"]
RUN dotnet restore "DockerInfNet_Edlcarvalho/DockerInfNet_Edlcarvalho.csproj"
COPY . .
WORKDIR "/src/DockerInfNet_Edlcarvalho"
RUN dotnet build "DockerInfNet_Edlcarvalho.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerInfNet_Edlcarvalho.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerInfNet_Edlcarvalho.dll"]