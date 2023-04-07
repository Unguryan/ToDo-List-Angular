using MediatR;

namespace Tasks.App.CQRS.Queries.Items.GetItem
{
    public class GetItemQueryHandler : IRequestHandler<GetItemQuery, GetItemQueryResult>
    {
        public async Task<GetItemQueryResult> Handle(GetItemQuery request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
