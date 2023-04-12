using MediatR;
using Tasks.App.Services;

namespace Tasks.App.CQRS.Queries.Boards.GetUserBoards
{
    public class GetUserBoardsQueryHandler : IRequestHandler<GetUserBoardsQuery, GetUserBoardsQueryResult>
    {
        private readonly IBoardService _boardService;

        public GetUserBoardsQueryHandler(IBoardService boardService)
        {
            _boardService = boardService;
        }

        public async Task<GetUserBoardsQueryResult> Handle(GetUserBoardsQuery request, CancellationToken cancellationToken)
        {
            return await _boardService.GetUserBoardsAsync(request);
        }
    }
}
