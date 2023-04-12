using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Boards.ChangeBoardName
{
    public record ChangeBoardNameCommandResult(bool IsChanged, Board? Board);
}
