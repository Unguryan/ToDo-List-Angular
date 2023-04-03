namespace Tasks.App.Services
{
    public interface INotifyUserService
    {
        Task<NotifyUserCommandResult> NotifyUser(NotifyUserCommand request);
    }
}
