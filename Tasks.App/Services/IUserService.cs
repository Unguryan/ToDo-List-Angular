using Tasks.App.CQRS.Commands.User.AddUser;
using Tasks.App.CQRS.Commands.User.RemoveUser;
using Tasks.App.CQRS.Queries.User.GetUserById;

namespace Tasks.App.Services
{
    public interface IUserService
    {
        Task<GetUserByIdQueryResult> GetUserByIdQueryAsync(GetUserByIdQuery query);

        Task<AddUserCommandResult> AddUserAsync(AddUserCommand request);

        Task<RemoveUserCommandResult> RemoveUserAsync(RemoveUserCommand request);
    }
}
