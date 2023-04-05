using Tasks.App.CQRS.Commands.Token.GenerateToken;

namespace Tasks.App.Services
{
    public interface IJWTTokenGenerator
    {
        Task<GenerateTokenCommandResult> GenerateTokenAsync(GenerateTokenCommand request);
    }
}
