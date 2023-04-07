using Tasks.Domain.Models;

namespace Tasks.App.Services
{
    public interface IJWTTokenGenerator
    {
        Task<string> GenerateTokenAsync(User user);
    }
}
