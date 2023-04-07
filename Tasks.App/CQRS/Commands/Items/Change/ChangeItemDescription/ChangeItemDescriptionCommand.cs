using MediatR;

namespace Tasks.App.CQRS.Commands.Items.Change.ChangeItemDescription
{
    public record ChangeItemDescriptionCommand() : IRequest<ChangeItemDescriptionCommandResult>;
}
