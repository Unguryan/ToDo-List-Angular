using Tasks.App.CQRS.Commands.Item.Change.AddSubItem;
using Tasks.App.CQRS.Commands.Item.Change.ChangeItemAssignedTo;
using Tasks.App.CQRS.Commands.Item.Change.ChangeItemDescription;
using Tasks.App.CQRS.Commands.Item.Change.ChangeItemName;
using Tasks.App.CQRS.Commands.Item.Change.ChangeItemParentItem;
using Tasks.App.CQRS.Commands.Item.Change.ChangeItemState;
using Tasks.App.CQRS.Commands.Item.Change.RemoveSubItem;
using Tasks.App.CQRS.Commands.Item.CreateItem;
using Tasks.App.CQRS.Commands.Item.RemoveItem;
using Tasks.App.CQRS.Queries.Item.GetItem;

namespace Tasks.App.Services
{
    public interface IItemService 
    {
        Task<GetItemQueryResult> GetItemAsync(GetItemQuery query);

        Task<CreateItemCommandResult> CreateItemAsync(CreateItemCommand request);

        Task<RemoveItemCommandResult> RemoveItemAsync(RemoveItemCommand request);

        #region Change 

        Task<ChangeItemNameCommandResult> ChangeItemNameAsync(ChangeItemNameCommand request);

        Task<ChangeItemDescriptionCommandResult> ChangeItemDescriptionAsync(ChangeItemDescriptionCommand request);

        Task<ChangeItemStateCommandResult> ChangeItemStateAsync(ChangeItemStateCommand request);

        Task<ChangeItemAssignedToCommandResult> ChangeItemAssignedToAsync(ChangeItemAssignedToCommand request);

        Task<ChangeItemParentItemCommandResult> ChangeItemParentItemAsync(ChangeItemParentItemCommand request);

        Task<AddSubItemCommandResult> AddSubItemAsync(AddSubItemCommand request);

        Task<RemoveSubItemCommandResult> RemoveSubItemAsync(RemoveSubItemCommand request);
        
        #endregion

    }
}
