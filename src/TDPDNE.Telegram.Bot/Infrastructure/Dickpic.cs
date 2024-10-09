namespace TDPDNE.Telegram.Bot.Infrastructure;

public record Dickpic
{
    public Guid Id { get; init; }

    public byte[] Picture { get; init; } = default!;
}
