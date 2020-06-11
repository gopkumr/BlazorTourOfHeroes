#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
EXPOSE 80
COPY ./bin/release/netcoreapp3.1/publish /app
WORKDIR /app
ENTRYPOINT ["dotnet", "TourofHeroes.Server.dll"]