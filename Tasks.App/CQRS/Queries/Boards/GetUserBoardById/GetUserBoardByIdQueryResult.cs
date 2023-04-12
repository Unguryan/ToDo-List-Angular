using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Queries.Boards.GetUserBoardById
{
    public record GetUserBoardByIdQueryResult(bool IsFound, Board? Board);
}
