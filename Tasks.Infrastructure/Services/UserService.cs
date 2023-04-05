using Tasks.App.CQRS.Commands.User.AddUser;
using Tasks.App.CQRS.Commands.User.RemoveUser;
using Tasks.App.CQRS.Queries.User.GetUserById;
using Tasks.App.Services;

namespace Tasks.Infrastructure.Services
{
    public class UserService : IUserService
    {
        public Task<AddUserCommandResult> AddUserAsync(AddUserCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<GetUserByIdQueryResult> GetUserByIdQueryAsync(GetUserByIdQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<RemoveUserCommandResult> RemoveUserAsync(RemoveUserCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
