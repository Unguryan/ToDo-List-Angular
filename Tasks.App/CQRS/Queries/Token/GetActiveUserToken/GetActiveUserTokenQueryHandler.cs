using MediatR;

namespace Tasks.App.CQRS.Queries.Token.GetActiveUserToken
{
    public class GetActiveUserTokenQueryHandler : IRequestHandler<GetActiveUserTokenQuery, GetActiveUserTokenQueryResult>
    {
        public async Task<GetActiveUserTokenQueryResult> Handle(GetActiveUserTokenQuery request, CancellationToken cancellationToken)
        {

        }
    }
}
