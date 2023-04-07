using MediatR;

namespace Tasks.App.CQRS.Commands.Users.Logout
{
    public record LogoutCommand(string Token, int UserId) : IRequest<LogoutCommandResult>;
}
