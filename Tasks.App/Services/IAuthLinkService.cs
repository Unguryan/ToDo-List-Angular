using Tasks.App.CQRS.Commands.Auth.RemoveAuthTelegramLink;

namespace Tasks.App.Services
{
    public interface IAuthLinkService
    {
        Task<RemoveAuthTelegramLinkCommandResult> RemoveAuthTelegramLinkAsync(RemoveAuthTelegramLinkCommand request);
    }
}
