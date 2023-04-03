namespace Tasks.App.Services
{
    public interface INotifyUserService
    {
        Task<NotifyUserCommandResult> NotifyUserAsync(NotifyUserCommand request);
    }
}
