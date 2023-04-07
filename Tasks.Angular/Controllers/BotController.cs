using Microsoft.AspNetCore.Mvc;
using Tasks.Telegram.Services;
using Telegram.Bot.Types;

namespace Tasks.Angular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BotController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post(
             [FromBody] Update update,
             [FromServices] UpdateHandler handleUpdateService,
             CancellationToken cancellationToken)
        {
            await handleUpdateService.HandleUpdateAsync(update, cancellationToken);
            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return NotFound();
        }

    }
}
