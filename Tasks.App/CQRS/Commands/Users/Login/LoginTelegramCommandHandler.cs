using MediatR;

namespace Tasks.App.CQRS.Commands.Users.Login
{
    public class LoginTelegramCommandHandler : IRequestHandler<LoginTelegramCommand, LoginCommandResult>
    {
        public async Task<LoginCommandResult> Handle(LoginTelegramCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
