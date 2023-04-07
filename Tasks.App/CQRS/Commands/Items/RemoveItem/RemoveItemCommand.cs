using MediatR;

namespace Tasks.App.CQRS.Commands.Items.RemoveItem
{
    public record RemoveItemCommand() : IRequest<RemoveItemCommandResult>;
}
