namespace TDPDNE.Telegram.Bot.Configs;

public class BotConfiguration
{
    public static readonly string Configuration = nameof(BotConfiguration);

    public string BotToken { get; set; } = "";

    public string SupportContact { get; set; } = "";
}