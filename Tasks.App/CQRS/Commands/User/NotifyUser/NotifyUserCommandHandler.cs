using MediatR;

namespace Tasks.App.CQRS.Commands.User.NotifyUser
{
    public class NotifyUserCommandHandler : IRequestHandler<NotifyUserCommand, NotifyUserCommandResult>
    {
        public async Task<NotifyUserCommandResult> Handle(NotifyUserCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
