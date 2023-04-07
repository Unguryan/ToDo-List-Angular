using MediatR;

namespace Tasks.App.CQRS.Queries.Users.GetUserById
{
    public record GetUserByIdQuery() : IRequest<GetUserByIdQueryResult>;
}
