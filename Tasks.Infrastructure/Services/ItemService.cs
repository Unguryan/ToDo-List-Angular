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
using Tasks.App.Services;

namespace Tasks.Infrastructure.Services
{
    public class ItemService : IItemService
    {

        public Task<GetItemQueryResult> GetItemAsync(GetItemQuery query)
        {
            throw new NotImplementedException();
        }
        public Task<CreateItemCommandResult> CreateItemAsync(CreateItemCommand request)
        {
            throw new NotImplementedException();
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

        public Task<ChangeItemStateCommandResult> ChangeItemStateAsync(ChangeItemStateCommand request)
        {
            throw new NotImplementedException();
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
