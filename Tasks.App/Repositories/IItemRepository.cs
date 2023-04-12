using Tasks.Domain.Models;

namespace Tasks.App.Repositories
{
    public interface IItemRepository
    {
        Task<ItemComposite?> ChangeItemStateAsync(int itemId, ItemState newState);
        Task<ItemComposite> CreateItemAsync(int userId, int boardId, string name);
    }
}
