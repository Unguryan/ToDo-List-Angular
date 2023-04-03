using MediatR;

namespace Tasks.App.CQRS.Commands.Board.CreateBoard
{
    public record CreateBoardCommand() : IRequest<CreateBoardCommandResult>;
}
