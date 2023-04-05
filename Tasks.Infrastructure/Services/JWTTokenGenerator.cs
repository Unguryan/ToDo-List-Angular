using Tasks.App.CQRS.Commands.Token.GenerateToken;
using Tasks.App.Services;

namespace Tasks.Infrastructure.Services
{
    public class JWTTokenGenerator : IJWTTokenGenerator
    {
        public Task<GenerateTokenCommandResult> GenerateTokenAsync(GenerateTokenCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
