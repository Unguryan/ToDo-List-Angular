using MediatR;

namespace Tasks.App.CQRS.Commands.Auth.RemoveAuthTelegramLink
{
    public record RemoveAuthTelegramLinkCommand() : IRequest<RemoveAuthTelegramLinkCommandResult>;
}
