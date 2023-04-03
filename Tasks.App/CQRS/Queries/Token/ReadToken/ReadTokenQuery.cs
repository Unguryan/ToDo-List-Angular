using MediatR;

namespace Tasks.App.CQRS.Queries.Token.ReadToken
{
    public record ReadTokenQuery() : IRequest<ReadTokenQueryResult>;
}
