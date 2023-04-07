using MediatR;

namespace Tasks.App.CQRS.Queries.Tokens.ReadToken
{
    public record ReadTokenQuery(string TokenData) : IRequest<ReadTokenQueryResult>;
}
