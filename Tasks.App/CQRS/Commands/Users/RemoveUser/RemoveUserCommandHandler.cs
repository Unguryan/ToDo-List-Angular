using MediatR;

namespace Tasks.App.CQRS.Commands.Users.RemoveUser
{
    public class RemoveUserCommandHandler : IRequestHandler<RemoveUserCommand, RemoveUserCommandResult>
    {
        public async Task<RemoveUserCommandResult> Handle(RemoveUserCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
