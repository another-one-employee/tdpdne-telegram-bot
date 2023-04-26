namespace TDPDNE.Telegram.Bot.Configs;

public class BotConfiguration
{
    public static readonly string Configuration = nameof(BotConfiguration);

    public string BotToken { get; set; } = "";

    public string SupportContact { get; set; } = "";

    public string Donations { get; set; } = "";

    public int MinDelay { get; set; } = 1500;

    public int MaxDelay { get; set; } = 2000;
}