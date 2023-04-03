namespace Tasks.App.Services
{
    public interface IAuthUserService
    {
        Task<LoginCommandResult> LoginViaGitHubAsync(LoginGitHubCommand request);

        Task<LoginCommandResult> LoginViaTelegramAsync(LoginTelegramCommand request);

        Task<LogoutCommandResult> LogoutAsync(LogoutCommand request);
    }
}
