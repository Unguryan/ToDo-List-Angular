using MediatR;

namespace Tasks.App.CQRS.Commands.Items.CreateItem
{
    public record CreateItemCommand(int UserId, int BoardId, string Name) : IRequest<CreateItemCommandResult>;
}
