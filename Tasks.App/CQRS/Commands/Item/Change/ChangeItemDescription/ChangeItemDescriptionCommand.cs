using MediatR;

namespace Tasks.App.CQRS.Commands.Item.Change.ChangeItemDescription
{
    public record ChangeItemDescriptionCommand() : IRequest<ChangeItemDescriptionCommandResult>;
}
