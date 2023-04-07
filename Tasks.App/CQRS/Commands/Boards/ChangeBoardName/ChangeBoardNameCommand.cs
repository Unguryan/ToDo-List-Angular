using MediatR;

namespace Tasks.App.CQRS.Commands.Boards.ChangeBoardName
{
    public record ChangeBoardNameCommand() : IRequest<ChangeBoardNameCommandResult>;
}
