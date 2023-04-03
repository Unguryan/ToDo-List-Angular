using MediatR;

namespace Tasks.App.CQRS.Commands.User.Login
{
    public record LoginTelegramCommand() : IRequest<LoginCommandResult>;
}
