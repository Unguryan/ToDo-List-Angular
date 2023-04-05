using MediatR;

namespace Tasks.App.CQRS.Commands.Board.RemoveUserFromBoard
{
    public class RemoveUserFromBoardCommandHandler : IRequestHandler<RemoveUserFromBoardCommand, RemoveUserFromBoardCommandResult>
    {
        public async Task<RemoveUserFromBoardCommandResult> Handle(RemoveUserFromBoardCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
