using MediatR;

namespace Tasks.App.CQRS.Queries.Auth.GetAuthTelegramLink
{
    public record GetAuthTelegramLinkQuery() : IRequest<GetAuthTelegramLinkQueryResult>;
}
