using MediatR;

namespace Tasks.App.CQRS.Commands.User.Login
{
    public record LoginGitHubCommand() : IRequest<LoginCommandResult>;
}
