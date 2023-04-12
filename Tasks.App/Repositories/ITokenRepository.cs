using Tasks.Domain.Models;

namespace Tasks.App.Repositories
{
    public interface ITokenRepository
    {
        Task<Token> AddTokenAsync(string tokenData, User user);
        Task<Token?> GetActiveTokenByUserIdAsync(int id);
        Task<Token?> GetTokenByTokenDataAsync(string tokenData);
        Task<Token?> RemoveTokenAsync(string tokenData);
    }
}
