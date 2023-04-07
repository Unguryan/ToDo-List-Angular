using Tasks.App.CQRS.Commands.Users.NotifyUser;
using Tasks.App.Services;

namespace Tasks.Infrastructure.Services
{
    public class NotifyUserService : INotifyUserService
    {
        public Task<NotifyUserCommandResult> NotifyUserAsync(NotifyUserCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
