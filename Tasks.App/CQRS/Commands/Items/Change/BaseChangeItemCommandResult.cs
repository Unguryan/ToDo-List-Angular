using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Items.Change
{
    public record BaseChangeItemCommandResult(bool IsChanged, ItemComposite? Item);
}
