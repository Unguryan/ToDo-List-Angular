using MediatR;

namespace Tasks.App.CQRS.Commands.Item.Change.RemoveSubItem
{
    public record RemoveSubItemCommand() : IRequest<RemoveSubItemCommandResult>;
}
