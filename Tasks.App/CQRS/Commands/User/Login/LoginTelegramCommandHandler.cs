using MediatR;

namespace Tasks.App.CQRS.Commands.User.Login
{
    public class LoginTelegramCommandHandler : IRequestHandler<LoginTelegramCommand, LoginCommandResult>
    {
        public async Task<LoginCommandResult> Handle(LoginTelegramCommand request, CancellationToken cancellationToken)
        {

        }
    }
}
