using MediatR;
using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Queries.Boards.GetUserBoardById
{
    public record GetUserBoardByIdQuery(int UserId, int BoardId) : IRequest<GetUserBoardByIdQueryResult>;
}
