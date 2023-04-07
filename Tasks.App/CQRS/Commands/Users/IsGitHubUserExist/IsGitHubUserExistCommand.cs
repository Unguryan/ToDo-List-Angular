using MediatR;

namespace Tasks.App.CQRS.Commands.Users.IsGitHubUserExist
{
    public record IsGitHubUserExistCommand() : IRequest<IsGitHubUserExistCommandResult>;
}
