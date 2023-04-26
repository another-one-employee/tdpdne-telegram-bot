namespace TDPDNE.Telegram.Bot.Abstract;

public interface ITDPDNEWrapper
{
    Task<Stream> GetPicture(CancellationToken stoppingToken);
}
