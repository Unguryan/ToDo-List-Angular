using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tasks.App.CQRS.Commands.User.Login;
using Tasks.App.CQRS.Commands.User.Logout;

namespace Tasks.Angular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("login/telegram")]
        public async Task<LoginCommandResult> LoginTelegram([FromBody] LoginTelegramCommand form)
        {
            return await _mediator.Send(form);
        }

        [HttpPost]
        [Route("login/github")]
        public async Task<LoginCommandResult> LoginGitHub([FromBody] LoginGitHubCommand form)
        {
            return await _mediator.Send(form);
        }

        [HttpPost]
        [Route("logout")]
        public async Task<LogoutCommandResult> LoginGitHub([FromBody] LogoutCommand form)
        {
            return await _mediator.Send(form);
        }
    }
}
