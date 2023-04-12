using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Queries.Tokens.ReadToken
{
    public record ReadTokenQueryResult(User? User);
}
