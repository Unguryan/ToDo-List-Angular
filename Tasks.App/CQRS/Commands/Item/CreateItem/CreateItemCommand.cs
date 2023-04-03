using MediatR;

namespace Tasks.App.CQRS.Commands.Item.CreateItem
{
    public record CreateItemCommand() : IRequest<CreateItemCommandResult>;
}
