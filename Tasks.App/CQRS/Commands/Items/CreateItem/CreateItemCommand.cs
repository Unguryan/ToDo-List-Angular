using MediatR;

namespace Tasks.App.CQRS.Commands.Items.CreateItem
{
    public record CreateItemCommand() : IRequest<CreateItemCommandResult>;
}
