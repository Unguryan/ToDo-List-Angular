using MediatR;

namespace Tasks.App.CQRS.Commands.Board.CreateBoard
{
    public class CreateBoardCommandHandler : IRequestHandler<CreateBoardCommand, CreateBoardCommandResult>
    {
        public async Task<CreateBoardCommandResult> Handle(CreateBoardCommand request, CancellationToken cancellationToken)
        {

        }
    }
}
