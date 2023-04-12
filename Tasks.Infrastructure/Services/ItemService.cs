using Tasks.App.CQRS.Commands.Items.Change.AddSubItem;
using Tasks.App.CQRS.Commands.Items.Change.ChangeItemAssignedTo;
using Tasks.App.CQRS.Commands.Items.Change.ChangeItemDescription;
using Tasks.App.CQRS.Commands.Items.Change.ChangeItemName;
using Tasks.App.CQRS.Commands.Items.Change.ChangeItemParentItem;
using Tasks.App.CQRS.Commands.Items.Change.ChangeItemState;
using Tasks.App.CQRS.Commands.Items.Change.RemoveSubItem;
using Tasks.App.CQRS.Commands.Items.CreateItem;
using Tasks.App.CQRS.Commands.Items.RemoveItem;
using Tasks.App.CQRS.Queries.Items.GetItem;
using Tasks.App.Repositories;
using Tasks.App.Services;

namespace Tasks.Infrastructure.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IBoardService _boardService;

        public ItemService(IItemRepository itemRepository, IBoardService boardService)
        {
            _itemRepository = itemRepository;
            _boardService = boardService;
        }

        public Task<GetItemQueryResult> GetItemAsync(GetItemQuery query)
        {
            throw new NotImplementedException();
        }
        public async Task<CreateItemCommandResult> CreateItemAsync(CreateItemCommand request)
        {
            if(await _boardService.IsUserInBoardAsync(request.BoardId, request.UserId))
            {
                var item = await _itemRepository.CreateItemAsync(request.UserId, request.BoardId, request.Name);
                return new CreateItemCommandResult(true, item);
            }

            return new CreateItemCommandResult(false, null);
        }

        public Task<RemoveItemCommandResult> RemoveItemAsync(RemoveItemCommand request)
        {
            throw new NotImplementedException();
        }


        public Task<ChangeItemAssignedToCommandResult> ChangeItemAssignedToAsync(ChangeItemAssignedToCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<ChangeItemDescriptionCommandResult> ChangeItemDescriptionAsync(ChangeItemDescriptionCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<ChangeItemNameCommandResult> ChangeItemNameAsync(ChangeItemNameCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<ChangeItemParentItemCommandResult> ChangeItemParentItemAsync(ChangeItemParentItemCommand request)
        {
            throw new NotImplementedException();
        }

        public async Task<ChangeItemStateCommandResult> ChangeItemStateAsync(ChangeItemStateCommand request)
        {
            if (await _boardService.IsUserInBoardAsync(request.BoardId, request.UserId))
            {
                var item = await _itemRepository.ChangeItemStateAsync(request.ItemId, request.NewState);
                return new ChangeItemStateCommandResult(item != null, item);
            }

            return new ChangeItemStateCommandResult(false, null);
        }

        public Task<AddSubItemCommandResult> AddSubItemAsync(AddSubItemCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<RemoveSubItemCommandResult> RemoveSubItemAsync(RemoveSubItemCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
