namespace Tasks.App.Services
{
    public interface IUserService
    {
        Task<Get>

        Task<AddUserCommandResult> AddUserAsync(AddUserCommand request);

        Task<RemoveUserCommandResult> RemoveUserAsync(RemoveUserCommand request);
    }
}
