using Tasks.Domain.Models;

namespace Tasks.App.Repositories
{
    public interface IBoardRepository
    {
        Task<Board?> AddUserToBoardAsync(int boardId, int userIdToAdd);
        Task<Board?> ChangeBoardNameAsync(int boardId, string newName);
        Task<Board> CreateBoardAsync(int userId, string name);
        Task<Board?> GetBoardByIdAsync(int boardId);
        Task<List<Board>?> GetBoardsByUserIdAsync(int userId);
    }
}
