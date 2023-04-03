using MediatR;

namespace Tasks.App.CQRS.Commands.Item.RemoveItem
{
    public record RemoveItemCommand() : IRequest<RemoveItemCommandResult>;
}
