using MediatR;

namespace Tasks.App.CQRS.Commands.User.Logout
{
    public class LogoutCommandHandler : IRequestHandler<LogoutCommand, LogoutCommandResult>
    {
        public async Task<LogoutCommandResult> Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
