using MediatR;
using Tasks.App.Services;

namespace Tasks.App.CQRS.Commands.Users.NotifyUser
{
    public class NotifyUserCommandHandler : IRequestHandler<NotifyUserCommand, NotifyUserCommandResult>
    {
        private readonly INotifyUserService _notifyUserService;

        public NotifyUserCommandHandler(INotifyUserService notifyUserService)
        {
            _notifyUserService = notifyUserService;
        }

        public async Task<NotifyUserCommandResult> Handle(NotifyUserCommand request, CancellationToken cancellationToken)
        {
            return await _notifyUserService.NotifyUserAsync(request);
        }
    }
}
