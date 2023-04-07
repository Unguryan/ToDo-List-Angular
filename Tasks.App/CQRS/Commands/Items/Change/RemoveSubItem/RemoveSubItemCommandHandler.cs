using MediatR;

namespace Tasks.App.CQRS.Commands.Items.Change.RemoveSubItem
{
    public class RemoveSubItemCommandHandler : IRequestHandler<RemoveSubItemCommand, RemoveSubItemCommandResult>
    {
        public async Task<RemoveSubItemCommandResult> Handle(RemoveSubItemCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
