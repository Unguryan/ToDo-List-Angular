using Tasks.App.CQRS.Commands.Users.Login;
using Tasks.App.CQRS.Commands.Users.Logout;
using Tasks.App.Services;

namespace Tasks.Auth.Services
{
    public class AuthUserService : IAuthUserService
    {
        public Task<LoginCommandResult> LoginViaGitHubAsync(LoginGitHubCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<LoginCommandResult> LoginViaTelegramAsync(LoginTelegramCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<LogoutCommandResult> LogoutAsync(LogoutCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
