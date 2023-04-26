namespace TDPDNE.Telegram.Bot.Exceptions;

public sealed class ServiceUnavailableException : Exception
{
    public ServiceUnavailableException(string message, object dataKey, object? dataValue)
        : base(message)
    {
        Data.Add(dataKey, dataValue);
    }
}
