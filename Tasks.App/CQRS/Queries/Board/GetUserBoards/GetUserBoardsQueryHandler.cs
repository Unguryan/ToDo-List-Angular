using MediatR;

namespace Tasks.App.CQRS.Queries.Board.GetUserBoards
{
    public class GetUserBoardsQueryHandler : IRequestHandler<GetUserBoardsQuery, GetUserBoardsQueryResult>
    {
        public async Task<GetUserBoardsQueryResult> Handle(GetUserBoardsQuery request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
