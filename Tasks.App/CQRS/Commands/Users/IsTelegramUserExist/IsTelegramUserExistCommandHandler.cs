using MediatR;
using Tasks.App.Services;

namespace Tasks.App.CQRS.Commands.Users.IsTelegramUserExist
{
    public class IsTelegramUserExistCommandHandler : IRequestHandler<IsTelegramUserExistCommand, IsTelegramUserExistCommandResult>
    {
        private readonly IUserService _userService;

        public IsTelegramUserExistCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IsTelegramUserExistCommandResult> Handle(IsTelegramUserExistCommand request, CancellationToken cancellationToken)
        {
            return await _userService.IsTelegramUserExistAsync(request);
        }
    }
}
