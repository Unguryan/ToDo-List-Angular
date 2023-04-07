using MediatR;

namespace Tasks.App.CQRS.Commands.Users.AddUser
{
    public record AddUserCommand(string Name, string? TelegramId = "", string? GitHubUserName = "") : IRequest<AddUserCommandResult>;
}
