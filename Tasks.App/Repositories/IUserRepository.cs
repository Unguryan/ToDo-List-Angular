using Tasks.Domain.Models;

namespace Tasks.App.Repositories
{
    public interface IUserRepository
    {
        Task<User> AddUserAsync(string name, string? telegramId = "", string? gitHubUserName = "");

        Task<User?> GetUserByHubUserNameAsync(string gitHubUserName);

        Task<User?> GetUserByTelegramIdAsync(string telegramId);

        Task<bool> IsFreeUsername(string username);

        Task<bool> AddUsername(int userId, string username);
    }
}
