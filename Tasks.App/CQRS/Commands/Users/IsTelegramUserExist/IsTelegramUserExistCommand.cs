using MediatR;

namespace Tasks.App.CQRS.Commands.Users.IsTelegramUserExist
{
    public record IsTelegramUserExistCommand(string TelegramId) : IRequest<IsTelegramUserExistCommandResult>;
}
