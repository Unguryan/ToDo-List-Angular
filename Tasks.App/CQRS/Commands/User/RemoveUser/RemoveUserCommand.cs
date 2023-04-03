using MediatR;

namespace Tasks.App.CQRS.Commands.User.RemoveUser
{
    public record RemoveUserCommand() : IRequest<RemoveUserCommandResult>;
}
