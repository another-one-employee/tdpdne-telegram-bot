FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TDPDNE.Telegram.Bot/TDPDNE.Telegram.Bot.csproj", "TDPDNE.Telegram.Bot/"]
RUN dotnet restore "TDPDNE.Telegram.Bot/TDPDNE.Telegram.Bot.csproj"
COPY . .
WORKDIR "/src/TDPDNE.Telegram.Bot"
RUN dotnet build "TDPDNE.Telegram.Bot.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TDPDNE.Telegram.Bot.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ["TDPDNE.Telegram.Bot.exe"]