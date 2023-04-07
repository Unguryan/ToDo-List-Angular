using MediatR;

namespace Tasks.App.CQRS.Commands.Boards.RemoveUserFromBoard
{
    public record RemoveUserFromBoardCommand() : IRequest<RemoveUserFromBoardCommandResult>;
}
