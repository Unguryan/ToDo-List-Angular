using MediatR;
using System.Xml.Linq;
using Tasks.App.CQRS.Commands.Users.AddUser;
using Tasks.App.CQRS.Commands.Users.IsGitHubUserExist;
using Tasks.App.CQRS.Commands.Users.IsTelegramUserExist;
using Tasks.App.CQRS.Commands.Users.RemoveUser;
using Tasks.App.CQRS.Queries.Users.GetUserById;
using Tasks.App.Repositories;
using Tasks.App.Services;
using Tasks.Domain.Models;

namespace Tasks.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<AddUserCommandResult> AddUserAsync(AddUserCommand request)
        {
            User? user = null;

            if (!string.IsNullOrEmpty(request.TelegramId))
            {
                user = await _userRepository.GetUserByTelegramIdAsync(request.TelegramId);
            }
            else if (!string.IsNullOrEmpty(request.GitHubUserName))
            {
                user = await _userRepository.GetUserByHubUserNameAsync(request.GitHubUserName);
            }

            if(user != null)
            {
                return new AddUserCommandResult(user);
            }

            var res = await _userRepository.AddUserAsync(request.Name, request.TelegramId, request.GitHubUserName);
            return new AddUserCommandResult(res);
        }

        public Task<GetUserByIdQueryResult> GetUserByIdAsync(GetUserByIdQuery query)
        {
            throw new NotImplementedException();
        }

        public async Task<IsGitHubUserExistCommandResult> IsGitHubUserExistAsync(IsGitHubUserExistCommand request)
        {
            throw new NotImplementedException();
        }

        public async Task<IsTelegramUserExistCommandResult> IsTelegramUserExistAsync(IsTelegramUserExistCommand request)
        {
            var user = await _userRepository.GetUserByTelegramIdAsync(request.TelegramId);

            return new IsTelegramUserExistCommandResult(user != null, user);
        }

        public Task<RemoveUserCommandResult> RemoveUserAsync(RemoveUserCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
