using MediatR;

namespace Tasks.App.CQRS.Commands.Items.Change.ChangeItemAssignedTo
{
    public record ChangeItemAssignedToCommand() : IRequest<ChangeItemAssignedToCommandResult>;
}
