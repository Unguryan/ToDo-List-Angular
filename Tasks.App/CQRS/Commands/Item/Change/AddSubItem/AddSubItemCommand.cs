using MediatR;

namespace Tasks.App.CQRS.Commands.Item.Change.AddSubItem
{
    public record AddSubItemCommand() : IRequest<AddSubItemCommandResult>;
}
