namespace TDPDNE.Telegram.Bot.Extensions;

using TDPDNE.Telegram.Bot.Configs;

public static class BotConfigurationExtensions
{
    public static void OverrideFromEnvs(this BotConfiguration botConfiguration)
    {
        botConfiguration.BotToken = Environment.GetEnvironmentVariable("BotConfiguration__BotToken") ?? botConfiguration.BotToken;
        botConfiguration.Support = Environment.GetEnvironmentVariable("BotConfiguration__Support") ?? botConfiguration.Support;
        botConfiguration.Donations = Environment.GetEnvironmentVariable("BotConfiguration__Donations") ?? botConfiguration.Donations;
    }
}
