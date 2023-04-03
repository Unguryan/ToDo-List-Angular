using MediatR;

namespace Tasks.App.CQRS.Commands.Item.Change.ChangeItemName
{
    public record ChangeItemNameCommand() : IRequest<ChangeItemNameCommandResult>;
}
