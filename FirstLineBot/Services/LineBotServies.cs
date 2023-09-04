using FirstLineBot.Models;
using Microsoft.Extensions.Options;

namespace FirstLineBot.Services
{
    public class LineBotServies
    {
        private readonly IOptions<LineBotSettings> _lineBotSettings;
        private readonly string accessToken;
        private readonly string channelSecret;
        public LineBotServies(IOptions<LineBotSettings> lineBotSettings)
        {
            _lineBotSettings = lineBotSettings;
            accessToken = lineBotSettings.Value.AccessToken;
            channelSecret = lineBotSettings.Value.ChannelSecret;
        }
    }
}
