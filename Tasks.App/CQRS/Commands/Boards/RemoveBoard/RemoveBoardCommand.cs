using MediatR;

namespace Tasks.App.CQRS.Commands.Boards.RemoveBoard
{
    public record RemoveBoardCommand() : IRequest<RemoveBoardCommandResult>;
}
