using MediatR;

namespace Tasks.App.CQRS.Commands.Item.Change.AddSubItem
{
    public class AddSubItemCommandHandler : IRequestHandler<AddSubItemCommand, AddSubItemCommandResult>
    {
        public async Task<AddSubItemCommandResult> Handle(AddSubItemCommand request, CancellationToken cancellationToken)
        {

        }
    }
}
