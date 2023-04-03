using MediatR;

namespace Tasks.App.CQRS.Queries.Board.GetUserBoardById
{
    public record GetUserBoardByIdQuery() : IRequest<GetUserBoardByIdQueryResult>;
}
