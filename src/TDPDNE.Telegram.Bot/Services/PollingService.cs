namespace TDPDNE.Telegram.Bot.Services;

using Microsoft.Extensions.Logging;
using TDPDNE.Telegram.Bot.Abstract;

public class PollingService : PollingServiceBase<ReceiverService>
{
    public PollingService(IServiceProvider serviceProvider, ILogger<PollingService> logger)
        : base(serviceProvider, logger)
    {
    }
}
