using MediatR;

namespace Tasks.App.CQRS.Queries.Users.GetUserById
{
    public record GetUserByIdQuery(int userId) : IRequest<GetUserByIdQueryResult>;
}
