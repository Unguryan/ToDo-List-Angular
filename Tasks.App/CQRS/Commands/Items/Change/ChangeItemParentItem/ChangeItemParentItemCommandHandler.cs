using MediatR;

namespace Tasks.App.CQRS.Commands.Items.Change.ChangeItemParentItem
{
    public class ChangeItemParentItemCommandHandler : IRequestHandler<ChangeItemParentItemCommand, ChangeItemParentItemCommandResult>
    {
        public async Task<ChangeItemParentItemCommandResult> Handle(ChangeItemParentItemCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
