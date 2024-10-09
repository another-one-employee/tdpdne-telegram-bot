namespace TDPDNE.Telegram.Bot.Infrastructure;

using Microsoft.EntityFrameworkCore;

public class TDPDNEDbContext : DbContext
{
    public DbSet<Dickpic> Dickpics { get; set; }

    public TDPDNEDbContext(DbContextOptions<TDPDNEDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public async Task<Stream> GetRandomDickpicAsStream()
    {
        var dickpic = await Dickpics
            .OrderBy(_ => Guid.NewGuid())
            .FirstAsync();

        return new MemoryStream(dickpic.Picture);
    }
}
