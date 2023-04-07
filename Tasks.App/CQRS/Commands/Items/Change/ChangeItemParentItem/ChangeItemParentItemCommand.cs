using MediatR;

namespace Tasks.App.CQRS.Commands.Items.Change.ChangeItemParentItem
{
    public record ChangeItemParentItemCommand() : IRequest<ChangeItemParentItemCommandResult>;
}
