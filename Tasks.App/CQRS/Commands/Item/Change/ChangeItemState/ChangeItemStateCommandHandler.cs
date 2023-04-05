using MediatR;

namespace Tasks.App.CQRS.Commands.Item.Change.ChangeItemState
{
    public class ChangeItemStateCommandHandler : IRequestHandler<ChangeItemStateCommand, ChangeItemStateCommandResult>
    {
        public async Task<ChangeItemStateCommandResult> Handle(ChangeItemStateCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
