using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Users.AddUser
{
    public record AddUserCommandResult(User CreatedUser);
}
