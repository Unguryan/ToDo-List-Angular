using MediatR;

namespace Tasks.App.CQRS.Commands.User.AddUser
{
    public record AddUserCommand() : IRequest<AddUserCommandResult>;
}
