using MediatR;

namespace Tasks.App.CQRS.Queries.Tokens.GetActiveUserToken
{
    public class GetActiveUserTokenQueryHandler : IRequestHandler<GetActiveUserTokenQuery, GetActiveUserTokenQueryResult>
    {
        public async Task<GetActiveUserTokenQueryResult> Handle(GetActiveUserTokenQuery request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
