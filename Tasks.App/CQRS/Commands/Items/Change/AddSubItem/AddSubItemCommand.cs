using MediatR;

namespace Tasks.App.CQRS.Commands.Items.Change.AddSubItem
{
    public record AddSubItemCommand() : IRequest<AddSubItemCommandResult>;
}
