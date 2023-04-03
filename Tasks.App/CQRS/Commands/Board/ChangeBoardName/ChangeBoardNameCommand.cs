using MediatR;

namespace Tasks.App.CQRS.Commands.Board.ChangeBoardName
{
    public record ChangeBoardNameCommand() : IRequest<ChangeBoardNameCommandResult>;
}
