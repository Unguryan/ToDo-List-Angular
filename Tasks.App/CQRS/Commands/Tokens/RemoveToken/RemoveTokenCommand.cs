using MediatR;

namespace Tasks.App.CQRS.Commands.Tokens.RemoveToken
{
    public record RemoveTokenCommand(string TokenData, int UserId) : IRequest<RemoveTokenCommandResult>;
}
