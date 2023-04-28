namespace TDPDNE.Telegram.Bot.Configs;

public class WrapperConfiguration
{
    public static readonly string Configuration = nameof(WrapperConfiguration);

    public string TDPDNEApiUrl { get; set; } = "";

    public string TDPDNEImageStorageUrl { get; set; } = "";

    public int MagickFuzzPercentage { get; set; } = default;

    public int AttemptsMaxCount { get; set; } = 10;

    public int MinId { get; set; } = default;
    public int MaxId { get; set; } = default;
}
