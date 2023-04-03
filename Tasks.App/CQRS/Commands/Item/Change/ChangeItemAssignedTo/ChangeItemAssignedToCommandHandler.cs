using MediatR;

namespace Tasks.App.CQRS.Commands.Item.Change.ChangeItemAssignedTo
{
    public class ChangeItemAssignedToCommandHandler : IRequestHandler<ChangeItemAssignedToCommand, ChangeItemAssignedToCommandResult>
    {
        public async Task<ChangeItemAssignedToCommandResult> Handle(ChangeItemAssignedToCommand request, CancellationToken cancellationToken)
        {

        }
    }
}
