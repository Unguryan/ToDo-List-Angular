using MediatR;

namespace Tasks.App.CQRS.Commands.Token.RemoveToken
{
    public record RemoveTokenCommand() : IRequest<RemoveTokenCommandResult>;
}
