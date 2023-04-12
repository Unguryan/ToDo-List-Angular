using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Items.Change.ChangeItemParentItem
{
    public record ChangeItemParentItemCommandResult : BaseChangeItemCommandResult
    {
        public ChangeItemParentItemCommandResult(bool isChanged, ItemComposite? item) : base(isChanged, item)
        {
        }
    }
}
