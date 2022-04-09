FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DevOpsDemo/DevOpsDemo.csproj", "DevOpsDemo/"]
RUN dotnet restore "DevOpsDemo/DevOpsDemo.csproj"
COPY . .
WORKDIR "/src/DevOpsDemo"
RUN dotnet build "DevOpsDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DevOpsDemo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DevOpsDemo.dll"]
