using MediatR;

namespace Tasks.App.CQRS.Commands.Item.CreateItem
{
    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, CreateItemCommandResult>
    {
        public async Task<CreateItemCommandResult> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
