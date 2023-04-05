using MediatR;

namespace Tasks.App.CQRS.Queries.User.GetUserById
{
    public record GetUserByIdQuery() : IRequest<GetUserByIdQueryResult>;
}
