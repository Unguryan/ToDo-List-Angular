using Tasks.App.CQRS.Commands.Users.Login;
using Tasks.App.CQRS.Commands.Users.Logout;

namespace Tasks.App.Services
{
    public interface IAuthUserService
    {
        Task<LoginCommandResult> LoginViaGitHubAsync(LoginGitHubCommand request);

        Task<LoginCommandResult> LoginViaTelegramAsync(LoginTelegramCommand request);

        Task<LogoutCommandResult> LogoutAsync(LogoutCommand request);
    }
}
