using FirstLineBot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace FirstLineBot.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LineBotController : ControllerBase
    {
        private readonly IOptions<LineBotSettings> _lineBotSettings;
        private readonly string accessToken;
        private readonly string channelSecret;
        public LineBotController(IOptions<LineBotSettings> lineBotSettings)
        {
            _lineBotSettings = lineBotSettings;
            accessToken = lineBotSettings.Value.AccessToken;
            channelSecret = lineBotSettings.Value.ChannelSecret;
        }

        [HttpPost("Webhook")]
        public IActionResult Webhook()
        {
            return Ok();
        }
    }
}
