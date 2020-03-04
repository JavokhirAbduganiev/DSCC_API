FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["DSCC_CW1_5998_API/DSCC_CW1_5998_API.csproj", "DSCC_CW1_5998_API/"]
RUN dotnet restore "DSCC_CW1_5998_API/DSCC_CW1_5998_API.csproj"
COPY . .
WORKDIR "/src/DSCC_CW1_5998_API"
RUN dotnet build "DSCC_CW1_5998_API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DSCC_CW1_5998_API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DSCC_CW1_5998_API.dll"]