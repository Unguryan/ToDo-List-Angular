using MediatR;

namespace Tasks.App.CQRS.Commands.Users.Login
{
    public record LoginTelegramCommand() : IRequest<LoginCommandResult>;
}
