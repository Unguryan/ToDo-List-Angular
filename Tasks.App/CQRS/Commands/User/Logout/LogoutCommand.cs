using MediatR;

namespace Tasks.App.CQRS.Commands.User.Logout
{
    public record LogoutCommand() : IRequest<LogoutCommandResult>;
}
