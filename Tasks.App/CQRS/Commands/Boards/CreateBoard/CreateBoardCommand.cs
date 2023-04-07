using MediatR;

namespace Tasks.App.CQRS.Commands.Boards.CreateBoard
{
    public record CreateBoardCommand() : IRequest<CreateBoardCommandResult>;
}
