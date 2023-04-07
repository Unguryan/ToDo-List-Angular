using Tasks.App.CQRS.Commands.Auth.CreateAuthTelegramLink;

namespace Tasks.App.Services
{
    public interface IAuthLinkGenerator
    {
        Task<CreateAuthTelegramLinkCommandResult> GenerateAuthTelegramLinkAsync();
    }
}
