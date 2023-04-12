using MediatR;

namespace Tasks.App.CQRS.Commands.Boards.CreateBoard
{
    public record CreateBoardCommand(int UserId, string Name) : IRequest<CreateBoardCommandResult>;
}
