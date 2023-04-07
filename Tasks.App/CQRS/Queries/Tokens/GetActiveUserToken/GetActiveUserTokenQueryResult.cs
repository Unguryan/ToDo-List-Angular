using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Queries.Tokens.GetActiveUserToken
{
    public record GetActiveUserTokenQueryResult(bool isFound, Token? Token);
}
