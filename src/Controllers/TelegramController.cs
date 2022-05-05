using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;
using Newtonsoft.Json;

namespace XMinusBot.Controllers
{
    [Route("api/message")]
    [ApiController]
    public class TelegramController : ControllerBase
    {
        public readonly TelegramBotClient _telegramBotClient;

        public TelegramController(TelegramBot telegramBot)
        {
            _telegramBotClient = telegramBot.GetBot().Result;
        }

        [HttpPost("ping")]
        public async Task<IActionResult> Ping([FromBody]Update update)
        {
            var chatId = JsonConvert.DeserializeObject<Update>(update.ToString()).Message?.Chat.Id;
            await _telegramBotClient.SendTextMessageAsync(chatId, "cooming soon...");

            return Ok();
        }
    }
}
