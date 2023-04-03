using MediatR;

namespace Tasks.App.CQRS.Commands.Token.RemoveToken
{
    public class RemoveTokenCommandHandler : IRequestHandler<RemoveTokenCommand, RemoveTokenCommandResult>
    {
        public async Task<RemoveTokenCommandResult> Handle(RemoveTokenCommand request, CancellationToken cancellationToken)
        {

        }
    }
}
