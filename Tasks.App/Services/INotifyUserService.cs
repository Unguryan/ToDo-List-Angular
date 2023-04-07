using Tasks.App.CQRS.Commands.Users.NotifyUser;

namespace Tasks.App.Services
{
    public interface INotifyUserService
    {
        Task<NotifyUserCommandResult> NotifyUserAsync(NotifyUserCommand request);
    }
}
