using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Boards.AddUserToBoard
{
    public record AddUserToBoardCommandResult(bool IsAdded, Board? Board);
}
