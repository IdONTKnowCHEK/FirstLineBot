using FirstLineBot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace FirstLineBot.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LineBotController : ControllerBase
    {
        public LineBotController()
        {
        }

        [HttpPost("Webhook")]
        public IActionResult Webhook()
        {
            return Ok();
        }
    }
}
