using MediatR;

namespace Tasks.App.CQRS.Queries.Auth.GetAuthTelegramLink
{
    public class GetAuthTelegramLinkQueryHandler : IRequestHandler<GetAuthTelegramLinkQuery, GetAuthTelegramLinkQueryResult>
    {
        public async Task<GetAuthTelegramLinkQueryResult> Handle(GetAuthTelegramLinkQuery request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
