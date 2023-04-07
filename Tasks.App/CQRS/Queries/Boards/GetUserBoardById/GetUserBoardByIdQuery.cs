using MediatR;

namespace Tasks.App.CQRS.Queries.Boards.GetUserBoardById
{
    public record GetUserBoardByIdQuery() : IRequest<GetUserBoardByIdQueryResult>;
}
