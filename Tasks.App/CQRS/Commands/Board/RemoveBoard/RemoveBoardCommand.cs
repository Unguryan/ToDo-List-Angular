using MediatR;

namespace Tasks.App.CQRS.Commands.Board.RemoveBoard
{
    public record RemoveBoardCommand() : IRequest<RemoveBoardCommandResult>;
}
