using MediatR;

namespace Tasks.App.CQRS.Commands.Board.RemoveBoard
{
    public class RemoveBoardCommandHandler : IRequestHandler<RemoveBoardCommand, RemoveBoardCommandResult>
    {
        public async Task<RemoveBoardCommandResult> Handle(RemoveBoardCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
