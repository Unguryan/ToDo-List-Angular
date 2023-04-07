using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Tokens.RemoveToken
{
    public record RemoveTokenCommandResult(bool IsRemoved, Token? Token);
}
