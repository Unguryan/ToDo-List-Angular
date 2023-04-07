using MediatR;

namespace Tasks.App.CQRS.Commands.Users.Login
{
    public record LoginGitHubCommand() : IRequest<LoginCommandResult>;
}
