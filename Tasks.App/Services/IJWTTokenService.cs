using Tasks.App.CQRS.Commands.Token.AddToken;
using Tasks.App.CQRS.Commands.Token.RemoveToken;
using Tasks.App.CQRS.Queries.Token.GetActiveUserToken;
using Tasks.App.CQRS.Queries.Token.ReadToken;

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
