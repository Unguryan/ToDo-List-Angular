using MediatR;

namespace Tasks.App.CQRS.Queries.Board.GetUserBoards
{
    public record GetUserBoardsQuery() : IRequest<GetUserBoardsQueryResult>;
}
