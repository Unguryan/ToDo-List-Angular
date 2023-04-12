using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Items.CreateItem
{
    public record CreateItemCommandResult(bool IsCreated, ItemComposite? CreatedItem);
}
