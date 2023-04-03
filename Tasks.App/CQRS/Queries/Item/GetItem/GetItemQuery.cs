using MediatR;

namespace Tasks.App.CQRS.Queries.Item.GetItem
{
    public record GetItemQuery() : IRequest<GetItemQueryResult>;
}
