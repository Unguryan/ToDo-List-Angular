using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Items.Change.AddSubItem
{
    public record AddSubItemCommandResult : BaseChangeItemCommandResult
    {
        public AddSubItemCommandResult(bool isChanged, ItemComposite? item) : base(isChanged, item)
        {
        }
    }
}
