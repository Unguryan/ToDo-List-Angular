using MediatR;

namespace Tasks.App.CQRS.Commands.Item.Change.ChangeItemParentItem
{
    public record ChangeItemParentItemCommand() : IRequest<ChangeItemParentItemCommandResult>;
}
