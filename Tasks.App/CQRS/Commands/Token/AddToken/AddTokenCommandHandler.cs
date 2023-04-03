using MediatR;

namespace Tasks.App.CQRS.Commands.Token.AddToken
{
    public class AddTokenCommandHandler : IRequestHandler<AddTokenCommand, AddTokenCommandResult>
    {
        public async Task<AddTokenCommandResult> Handle(AddTokenCommand request, CancellationToken cancellationToken)
        {

        }
    }
}
