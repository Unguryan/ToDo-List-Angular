using MediatR;
using Tasks.App.Services;

namespace Tasks.App.CQRS.Commands.Users.AddUser
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, AddUserCommandResult>
    {
        private readonly IUserService _userService;

        public AddUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<AddUserCommandResult> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            return await _userService.AddUserAsync(request);
        }
    }
}
