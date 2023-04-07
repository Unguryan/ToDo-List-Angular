using Tasks.Domain.Models;

namespace Tasks.App.Repositories
{
    public interface ITokenRepository
    {
        Task<Token> AddTokenAsync(string tokenData, User user);
        Task<Token?> GetActiveTokenByUserId(int id);
        Task<Token?> RemoveTokenAsync(string tokenData);
    }
}
