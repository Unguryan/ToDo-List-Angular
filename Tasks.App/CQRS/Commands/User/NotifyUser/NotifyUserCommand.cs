using MediatR;

namespace Tasks.App.CQRS.Commands.User.NotifyUser
{
    public record NotifyUserCommand() : IRequest<NotifyUserCommandResult>;
}
