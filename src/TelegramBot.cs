using Telegram.Bot;

namespace XMinusBot
{
    public class TelegramBot
    {
        private readonly IConfiguration _configuration;

        public TelegramBot(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<TelegramBotClient> GetBot()
        {
            var telegramBot = new TelegramBotClient(_configuration["Token"]);

            var hook = $"{_configuration["Url"]}/api/message/ping";
            await telegramBot.SetWebhookAsync(hook);

            return telegramBot;
        }
    }
}
