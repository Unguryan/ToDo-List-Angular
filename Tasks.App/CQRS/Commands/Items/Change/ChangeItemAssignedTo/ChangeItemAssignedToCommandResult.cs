using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Items.Change.ChangeItemAssignedTo
{
    public record ChangeItemAssignedToCommandResult : BaseChangeItemCommandResult
    {
        public ChangeItemAssignedToCommandResult(bool isChanged, ItemComposite? item) : base(isChanged, item)
        {
        }
    }
}
