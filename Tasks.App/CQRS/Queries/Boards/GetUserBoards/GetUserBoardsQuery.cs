using MediatR;

namespace Tasks.App.CQRS.Queries.Boards.GetUserBoards
{
    public record GetUserBoardsQuery(int UserId) : IRequest<GetUserBoardsQueryResult>;
}
