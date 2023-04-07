using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tasks.App.CQRS.Commands.Auth.CreateAuthTelegramLink;
using Tasks.App.CQRS.Commands.Users.Login;
using Tasks.App.CQRS.Commands.Users.Logout;

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

        [HttpGet]
        [Route("login/telegram")]
        public async Task<CreateAuthTelegramLinkCommandResult> LoginTelegram()
        {
            return await _mediator.Send(new CreateAuthTelegramLinkCommand());
        }

        [HttpPost]
        [Route("login/github")]
        public async Task<LoginCommandResult> LoginGitHub([FromBody] LoginGitHubCommand form)
        {
            return await _mediator.Send(form);
        }

        [HttpPost]
        [Route("logout")]
        public async Task<LogoutCommandResult> Logout([FromBody] LogoutCommand form)
        {
            return await _mediator.Send(form);
        }
    }
}
