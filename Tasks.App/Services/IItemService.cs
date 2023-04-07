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
