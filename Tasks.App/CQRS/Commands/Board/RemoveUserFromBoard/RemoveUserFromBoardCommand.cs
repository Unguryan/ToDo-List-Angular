using MediatR;

namespace Tasks.App.CQRS.Commands.Board.RemoveUserFromBoard
{
    public record RemoveUserFromBoardCommand() : IRequest<RemoveUserFromBoardCommandResult>;
}
