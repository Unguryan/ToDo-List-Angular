using MediatR;

namespace Tasks.App.CQRS.Commands.Items.Change.ChangeItemState
{
    public record ChangeItemStateCommand() : IRequest<ChangeItemStateCommandResult>;
}
