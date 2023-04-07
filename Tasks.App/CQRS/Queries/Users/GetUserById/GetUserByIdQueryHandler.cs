using MediatR;

namespace Tasks.App.CQRS.Queries.Users.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, GetUserByIdQueryResult>
    {
        public async Task<GetUserByIdQueryResult> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
