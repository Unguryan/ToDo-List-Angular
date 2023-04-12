using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Items.Change.ChangeItemState
{
    public record ChangeItemStateCommandResult : BaseChangeItemCommandResult
    {
        public ChangeItemStateCommandResult(bool isChanged, ItemComposite? item) : base(isChanged, item)
        {
        }
    }
}
