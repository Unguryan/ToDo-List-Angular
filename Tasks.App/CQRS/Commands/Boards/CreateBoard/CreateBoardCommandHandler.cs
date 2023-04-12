using MediatR;
using Tasks.App.Services;

namespace Tasks.App.CQRS.Commands.Boards.CreateBoard
{
    public class CreateBoardCommandHandler : IRequestHandler<CreateBoardCommand, CreateBoardCommandResult>
    {
        private readonly IBoardService _boardService;

        public CreateBoardCommandHandler(IBoardService boardService)
        {
            _boardService = boardService;
        }

        public async Task<CreateBoardCommandResult> Handle(CreateBoardCommand request, CancellationToken cancellationToken)
        {
            return await _boardService.CreateBoardAsync(request);
        }
    }
}
