using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Items.Change.RemoveSubItem
{
    public record RemoveSubItemCommandResult : BaseChangeItemCommandResult
    {
        public RemoveSubItemCommandResult(bool isChanged, ItemComposite? item) : base(isChanged, item)
        {
        }
    }
}
