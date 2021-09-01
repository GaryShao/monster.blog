FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["./Monster.PersonalSpace.Blog.csproj", "Monster.PersonalSpace.Blog/"]
RUN dotnet restore "Monster.PersonalSpace.Blog/Monster.PersonalSpace.Blog.csproj"
COPY . .
WORKDIR "/src/Monster.PersonalSpace.Blog"
RUN dotnet build "Monster.PersonalSpace.Blog.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Monster.PersonalSpace.Blog.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Monster.PersonalSpace.Blog.dll"]