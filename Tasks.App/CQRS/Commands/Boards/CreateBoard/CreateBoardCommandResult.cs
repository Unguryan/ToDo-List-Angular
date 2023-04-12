using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Boards.CreateBoard
{
    public record CreateBoardCommandResult(Board CreatedBoard);
}
