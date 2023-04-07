using MediatR;

namespace Tasks.App.CQRS.Commands.Boards.AddUserToBoard
{
    public record AddUserToBoardCommand() : IRequest<AddUserToBoardCommandResult>;
}
