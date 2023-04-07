using Tasks.App.CQRS.Commands.Auth.RemoveAuthTelegramLink;
using Tasks.App.Services;

namespace Tasks.Auth.Services
{
    public class AuthLinkService : IAuthLinkService
    {
        public Task<RemoveAuthTelegramLinkCommandResult> RemoveAuthTelegramLinkAsync(RemoveAuthTelegramLinkCommand request)
        {
            throw new NotImplementedException();
        }

    }
}
