using MediatR;

namespace Tasks.App.CQRS.Commands.User.AddUser
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, AddUserCommandResult>
    {
        public async Task<AddUserCommandResult> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {

        }
    }
}
