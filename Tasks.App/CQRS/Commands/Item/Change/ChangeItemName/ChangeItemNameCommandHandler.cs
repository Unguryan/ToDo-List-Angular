using MediatR;

namespace Tasks.App.CQRS.Commands.Item.Change.ChangeItemName
{
    public class ChangeItemNameCommandHandler : IRequestHandler<ChangeItemNameCommand, ChangeItemNameCommandResult>
    {
        public async Task<ChangeItemNameCommandResult> Handle(ChangeItemNameCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
