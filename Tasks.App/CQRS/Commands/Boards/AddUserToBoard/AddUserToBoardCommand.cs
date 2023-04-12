using MediatR;

namespace Tasks.App.CQRS.Commands.Boards.AddUserToBoard
{
    public record AddUserToBoardCommand(int BoardId, int UserId, int UserIdToAdd) : IRequest<AddUserToBoardCommandResult>;
}
