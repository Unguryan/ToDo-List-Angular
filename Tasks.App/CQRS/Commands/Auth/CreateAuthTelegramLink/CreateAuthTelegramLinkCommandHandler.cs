using MediatR;
using Tasks.App.Services;

namespace Tasks.App.CQRS.Commands.Auth.CreateAuthTelegramLink
{
    public class CreateAuthTelegramLinkCommandHandler : IRequestHandler<CreateAuthTelegramLinkCommand, CreateAuthTelegramLinkCommandResult>
    {
        private readonly IAuthLinkGenerator _authLinkGenerator;

        public CreateAuthTelegramLinkCommandHandler(IAuthLinkGenerator authLinkGenerator)
        {
            _authLinkGenerator = authLinkGenerator;
        }

        public async Task<CreateAuthTelegramLinkCommandResult> Handle(CreateAuthTelegramLinkCommand request, CancellationToken cancellationToken)
        {
            return await _authLinkGenerator.GenerateAuthTelegramLinkAsync();
        }
    }
}
