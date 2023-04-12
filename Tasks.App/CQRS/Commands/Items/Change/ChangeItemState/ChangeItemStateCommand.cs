using MediatR;
using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Items.Change.ChangeItemState
{
    public record ChangeItemStateCommand(int UserId, int BoardId, int ItemId, ItemState NewState) : IRequest<ChangeItemStateCommandResult>;
}
