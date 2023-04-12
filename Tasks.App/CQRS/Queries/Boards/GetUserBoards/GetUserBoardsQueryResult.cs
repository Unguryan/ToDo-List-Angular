using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Queries.Boards.GetUserBoards
{
    public record GetUserBoardsQueryResult(List<Board>? Boards);
}
