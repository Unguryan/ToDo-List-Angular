using Tasks.App.CQRS.Commands.Token.AddToken;
using Tasks.App.CQRS.Commands.Token.RemoveToken;
using Tasks.App.CQRS.Queries.Token.GetActiveUserToken;
using Tasks.App.CQRS.Queries.Token.ReadToken;
using Tasks.App.Services;

namespace Tasks.Infrastructure.Services
{
    public class JWTTokenService : IJWTTokenService
    {
        public Task<AddTokenCommandResult> AddTokenAsync(AddTokenCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<GetActiveUserTokenQueryResult> GetActiveUserTokenAsync(GetActiveUserTokenQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<ReadTokenQueryResult> ReadTokenAsync(ReadTokenQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<RemoveTokenCommandResult> RemoveTokenAsync(RemoveTokenCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
