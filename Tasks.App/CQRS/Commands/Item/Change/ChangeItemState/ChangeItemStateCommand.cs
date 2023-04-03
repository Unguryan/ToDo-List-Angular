using MediatR;

namespace Tasks.App.CQRS.Commands.Item.Change.ChangeItemState
{
    public record ChangeItemStateCommand() : IRequest<ChangeItemStateCommandResult>;
}
