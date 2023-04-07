using MediatR;

namespace Tasks.App.CQRS.Commands.Auth.CreateAuthTelegramLink
{
    public record CreateAuthTelegramLinkCommand() : IRequest<CreateAuthTelegramLinkCommandResult>;
}
