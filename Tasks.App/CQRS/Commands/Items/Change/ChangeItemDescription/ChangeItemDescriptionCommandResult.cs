using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Items.Change.ChangeItemDescription
{
    public record ChangeItemDescriptionCommandResult : BaseChangeItemCommandResult
    {
        public ChangeItemDescriptionCommandResult(bool isChanged, ItemComposite? item) : base(isChanged, item)
        {
        }
    }
}
