using MediatR;

namespace Tasks.App.CQRS.Commands.Items.RemoveItem
{
    public class RemoveItemCommandHandler : IRequestHandler<RemoveItemCommand, RemoveItemCommandResult>
    {
        public async Task<RemoveItemCommandResult> Handle(RemoveItemCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
