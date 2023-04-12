using MediatR;
using Tasks.App.Services;

namespace Tasks.App.CQRS.Commands.Items.Change.ChangeItemState
{
    public class ChangeItemStateCommandHandler : IRequestHandler<ChangeItemStateCommand, ChangeItemStateCommandResult>
    {
        private readonly IItemService _itemService;

        public ChangeItemStateCommandHandler(IItemService itemService)
        {
            _itemService = itemService;
        }

        public async Task<ChangeItemStateCommandResult> Handle(ChangeItemStateCommand request, CancellationToken cancellationToken)
        {
            return await _itemService.ChangeItemStateAsync(request);
        }
    }
}
