using MediatR;

namespace Tasks.App.CQRS.Queries.Boards.GetUserBoards
{
    public record GetUserBoardsQuery() : IRequest<GetUserBoardsQueryResult>;
}
