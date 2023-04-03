using MediatR;

namespace Tasks.App.CQRS.Queries.Token.GetActiveUserToken
{
    public record GetActiveUserTokenQuery() : IRequest<GetActiveUserTokenQueryResult>;
}
