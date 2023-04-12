using MediatR;
using Tasks.App.Services;

namespace Tasks.App.CQRS.Queries.Boards.GetUserBoardById
{
    public class GetUserBoardByIdQueryHandler : IRequestHandler<GetUserBoardByIdQuery, GetUserBoardByIdQueryResult>
    {
        private readonly IBoardService _boardService;

        public GetUserBoardByIdQueryHandler(IBoardService boardService)
        {
            _boardService = boardService;
        }

        public async Task<GetUserBoardByIdQueryResult> Handle(GetUserBoardByIdQuery request, CancellationToken cancellationToken)
        {
            return await _boardService.GetUserBoardByIdAsync(request);
        }
    }
}
