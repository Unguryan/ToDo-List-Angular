using MediatR;

namespace Tasks.App.CQRS.Commands.Item.Change.ChangeItemAssignedTo
{
    public record ChangeItemAssignedToCommand() : IRequest<ChangeItemAssignedToCommandResult>;
}
