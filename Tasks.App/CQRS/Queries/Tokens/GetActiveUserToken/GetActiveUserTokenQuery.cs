using MediatR;

namespace Tasks.App.CQRS.Queries.Tokens.GetActiveUserToken
{
    public record GetActiveUserTokenQuery(int UserId) : IRequest<GetActiveUserTokenQueryResult>;
}
