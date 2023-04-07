using Microsoft.Extensions.Options;
using Tasks.App.CQRS.Commands.Auth.CreateAuthTelegramLink;
using Tasks.App.Services;
using Tasks.Domain.Options;

namespace Tasks.Auth.Services
{
    public class AuthLinkGenerator : IAuthLinkGenerator
    {
        private const string BaseUrl = "https://t.me/{0}?start=auth={1}";

        private readonly IOptions<TelegramBotOptions> _options;

        public AuthLinkGenerator(IOptions<TelegramBotOptions> options)
        {
            _options = options;
        }

        public async Task<CreateAuthTelegramLinkCommandResult> GenerateAuthTelegramLinkAsync()
        {
            var guid = Guid.NewGuid().ToString();
            var url = string.Format(BaseUrl, _options.Value.BotName, guid);
            return new CreateAuthTelegramLinkCommandResult(url, guid);
        }
    }
}
