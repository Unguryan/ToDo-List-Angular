using MediatR;
using Tasks.App.Services;

namespace Tasks.App.CQRS.Commands.Items.CreateItem
{
    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, CreateItemCommandResult>
    {
        private readonly IItemService _itemService;

        public CreateItemCommandHandler(IItemService itemService)
        {
            _itemService = itemService;
        }

        public async Task<CreateItemCommandResult> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            return await _itemService.CreateItemAsync(request);
        }
    }
}
