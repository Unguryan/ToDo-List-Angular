using MediatR;

namespace Tasks.App.CQRS.Commands.Items.Change.AddSubItem
{
    public class AddSubItemCommandHandler : IRequestHandler<AddSubItemCommand, AddSubItemCommandResult>
    {
        public async Task<AddSubItemCommandResult> Handle(AddSubItemCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
