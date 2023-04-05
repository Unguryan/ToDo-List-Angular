using MediatR;

namespace Tasks.App.CQRS.Commands.Item.Change.ChangeItemDescription
{
    public class ChangeItemDescriptionCommandHandler : IRequestHandler<ChangeItemDescriptionCommand, ChangeItemDescriptionCommandResult>
    {
        public async Task<ChangeItemDescriptionCommandResult> Handle(ChangeItemDescriptionCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
