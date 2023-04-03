using MediatR;

namespace Tasks.App.CQRS.Commands.Board.AddUserToBoard
{
    public record AddUserToBoardCommand() : IRequest<AddUserToBoardCommandResult>;
}
