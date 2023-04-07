using MediatR;

namespace Tasks.App.CQRS.Commands.Auth.RemoveAuthTelegramLink
{
    public class RemoveAuthTelegramLinkCommandHandler : IRequestHandler<RemoveAuthTelegramLinkCommand, RemoveAuthTelegramLinkCommandResult>
    {
        public async Task<RemoveAuthTelegramLinkCommandResult> Handle(RemoveAuthTelegramLinkCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
