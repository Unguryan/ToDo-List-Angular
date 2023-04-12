using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Items.Change.ChangeItemName
{
    public record ChangeItemNameCommandResult : BaseChangeItemCommandResult
    {
        public ChangeItemNameCommandResult(bool isChanged, ItemComposite? item) : base(isChanged, item)
        {
        }
    }
}
