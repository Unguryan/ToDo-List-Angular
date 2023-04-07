using MediatR;

namespace Tasks.App.CQRS.Queries.Boards.GetUserBoardById
{
    public class GetUserBoardByIdQueryHandler : IRequestHandler<GetUserBoardByIdQuery, GetUserBoardByIdQueryResult>
    {
        public async Task<GetUserBoardByIdQueryResult> Handle(GetUserBoardByIdQuery request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
