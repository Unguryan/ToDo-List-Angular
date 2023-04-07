using MediatR;

namespace Tasks.App.CQRS.Queries.Items.GetItem
{
    public record GetItemQuery() : IRequest<GetItemQueryResult>;
}
