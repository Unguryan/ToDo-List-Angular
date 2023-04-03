using MediatR;

namespace Tasks.App.CQRS.Queries.Item.GetItem
{
    public class GetItemQueryHandler : IRequestHandler<GetItemQuery, GetItemQueryResult>
    {
        public async Task<GetItemQueryResult> Handle(GetItemQuery request, CancellationToken cancellationToken)
        {

        }
    }
}
