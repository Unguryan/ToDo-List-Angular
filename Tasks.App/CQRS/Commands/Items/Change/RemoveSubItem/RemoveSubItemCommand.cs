using MediatR;

namespace Tasks.App.CQRS.Commands.Items.Change.RemoveSubItem
{
    public record RemoveSubItemCommand() : IRequest<RemoveSubItemCommandResult>;
}
