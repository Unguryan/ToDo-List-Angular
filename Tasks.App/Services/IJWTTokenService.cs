using Tasks.App.CQRS.Commands.Tokens.AddToken;
using Tasks.App.CQRS.Commands.Tokens.RemoveToken;
using Tasks.App.CQRS.Queries.Tokens.GetActiveUserToken;
using Tasks.App.CQRS.Queries.Tokens.ReadToken;

namespace Tasks.App.Services
{
    public interface IJWTTokenService
    {
        Task<GetActiveUserTokenQueryResult> GetActiveUserTokenAsync(GetActiveUserTokenQuery query);

        Task<ReadTokenQueryResult> ReadTokenAsync(ReadTokenQuery query);

        Task<AddTokenCommandResult> AddTokenAsync(AddTokenCommand request);

        Task<RemoveTokenCommandResult> RemoveTokenAsync(RemoveTokenCommand request);
    }
}
