using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Users.IsTelegramUserExist
{
    public record IsTelegramUserExistCommandResult(bool IsExist, User? TelUser);
}
