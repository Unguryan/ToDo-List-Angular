using MediatR;

namespace Tasks.App.CQRS.Commands.Token.GenerateToken
{
    public class GenerateTokenCommandHandler : IRequestHandler<GenerateTokenCommand, GenerateTokenCommandResult>
    {
        public async Task<GenerateTokenCommandResult> Handle(GenerateTokenCommand request, CancellationToken cancellationToken)
        {

        }
    }
}
