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

        Task<RemoveSubItemResult> RemoveSubItemAsync(RemoveSubItemCommand request);
        
        #endregion

    }
}
