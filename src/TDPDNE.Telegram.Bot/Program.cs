namespace TDPDNE.Telegram.Bot;

using global::Telegram.Bot;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TDPDNE.Telegram.Bot.Configs;
using TDPDNE.Telegram.Bot.Services;

internal class Program
{
    static async Task Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services.Configure<BotConfiguration>(
                    context.Configuration.GetSection(BotConfiguration.Configuration));

                services.AddHttpClient("telegram_bot_client")
                        .AddTypedClient<ITelegramBotClient>((httpClient, serviceProvider) =>
                        {
                            BotConfiguration botConfig = serviceProvider.GetConfiguration<BotConfiguration>();
                            TelegramBotClientOptions options = new(botConfig.BotToken);
                            return new TelegramBotClient(options, httpClient);
                        });

                services.AddScoped<UpdateHandler>();
                services.AddScoped<ReceiverService>();
                services.AddHostedService<PollingService>();
            })
            .Build();

        await host.RunAsync();
    }
}