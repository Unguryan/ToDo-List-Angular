using MediatR;

namespace Tasks.App.CQRS.Commands.Token.GenerateToken
{
    public record GenerateTokenCommand() : IRequest<GenerateTokenCommandResult>;
}
