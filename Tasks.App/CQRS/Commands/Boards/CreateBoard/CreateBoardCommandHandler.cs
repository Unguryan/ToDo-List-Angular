using MediatR;

namespace Tasks.App.CQRS.Commands.Boards.CreateBoard
{
    public class CreateBoardCommandHandler : IRequestHandler<CreateBoardCommand, CreateBoardCommandResult>
    {
        public async Task<CreateBoardCommandResult> Handle(CreateBoardCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
