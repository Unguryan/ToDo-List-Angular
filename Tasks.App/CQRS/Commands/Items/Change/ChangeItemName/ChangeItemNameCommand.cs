using MediatR;

namespace Tasks.App.CQRS.Commands.Items.Change.ChangeItemName
{
    public record ChangeItemNameCommand() : IRequest<ChangeItemNameCommandResult>;
}
