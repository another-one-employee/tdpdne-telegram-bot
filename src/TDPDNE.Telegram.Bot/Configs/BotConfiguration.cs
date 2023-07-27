namespace TDPDNE.Telegram.Bot.Configs;

public class BotConfiguration
{
    public static readonly string Configuration = nameof(BotConfiguration);

    public string BotToken { get; set; } = "";

    public string Support { get; set; } = "";

    public string Donations { get; set; } = "";
}