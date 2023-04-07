using MediatR;
using Tasks.Domain.Events;

namespace Tasks.App.CQRS.Commands.Users.NotifyUser
{
    public record NotifyUserCommand(IBaseEvent Event) : IRequest<NotifyUserCommandResult>;
}
