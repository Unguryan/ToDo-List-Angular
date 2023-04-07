using MediatR;

namespace Tasks.App.CQRS.Commands.Users.RemoveUser
{
    public record RemoveUserCommand() : IRequest<RemoveUserCommandResult>;
}
