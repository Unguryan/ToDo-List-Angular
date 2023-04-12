using MediatR;

namespace Tasks.App.CQRS.Commands.Boards.ChangeBoardName
{
    public record ChangeBoardNameCommand(int BoardId, int UserId, string NewName) : IRequest<ChangeBoardNameCommandResult>;
}
