using MediatR;
using Tasks.App.CQRS.Commands.Tokens.RemoveToken;
using Tasks.App.Services;

namespace Tasks.App.CQRS.Commands.Users.Logout
{
    public class LogoutCommandHandler : IRequestHandler<LogoutCommand, LogoutCommandResult>
    {
        private readonly IJWTTokenService _jWTTokenService;

        public LogoutCommandHandler(IJWTTokenService jWTTokenService)
        {
            _jWTTokenService = jWTTokenService;
        }

        public async Task<LogoutCommandResult> Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            var res = await _jWTTokenService.RemoveTokenAsync(new RemoveTokenCommand(request.Token, request.UserId));

            return new LogoutCommandResult(res.IsRemoved);
        }
    }
}
