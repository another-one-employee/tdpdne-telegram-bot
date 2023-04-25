namespace TDPDNE.Telegram.Bot.Services;

using global::Telegram.Bot;
using Microsoft.Extensions.Logging;
using TDPDNE.Telegram.Bot.Abstract;

public class ReceiverService : ReceiverServiceBase<UpdateHandler>
{
    public ReceiverService(
        ITelegramBotClient botClient,
        UpdateHandler updateHandler,
        ILogger<ReceiverServiceBase<UpdateHandler>> logger)
        : base(botClient, updateHandler, logger)
    {
    }
}
