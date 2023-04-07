using Tasks.App.CQRS.Commands.Users.AddUser;
using Tasks.App.CQRS.Commands.Users.IsGitHubUserExist;
using Tasks.App.CQRS.Commands.Users.IsTelegramUserExist;
using Tasks.App.CQRS.Commands.Users.RemoveUser;
using Tasks.App.CQRS.Queries.Users.GetUserById;

namespace Tasks.App.Services
{
    public interface IUserService
    {
        Task<GetUserByIdQueryResult> GetUserByIdAsync(GetUserByIdQuery query);

        Task<IsTelegramUserExistCommandResult> IsTelegramUserExistAsync(IsTelegramUserExistCommand command);

        Task<IsGitHubUserExistCommandResult> IsGitHubUserExistAsync(IsGitHubUserExistCommand command);

        Task<AddUserCommandResult> AddUserAsync(AddUserCommand request);

        Task<RemoveUserCommandResult> RemoveUserAsync(RemoveUserCommand request);
    }
}
