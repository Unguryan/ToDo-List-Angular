using MediatR;

namespace Tasks.App.CQRS.Commands.Token.AddToken
{
    public record AddTokenCommand() : IRequest<AddTokenCommandResult>;
}
