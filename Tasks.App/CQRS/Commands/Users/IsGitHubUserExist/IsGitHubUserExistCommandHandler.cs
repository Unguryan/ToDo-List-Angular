using MediatR;

namespace Tasks.App.CQRS.Commands.Users.IsGitHubUserExist
{
    public class IsGitHubUserExistCommandHandler : IRequestHandler<IsGitHubUserExistCommand, IsGitHubUserExistCommandResult>
    {
        public async Task<IsGitHubUserExistCommandResult> Handle(IsGitHubUserExistCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
