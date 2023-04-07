using MediatR;
using Tasks.Domain.Models;

namespace Tasks.App.CQRS.Commands.Tokens.AddToken
{
    public record AddTokenCommand(User User) : IRequest<AddTokenCommandResult>;
}
