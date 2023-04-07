using MediatR;
using Tasks.App.Services;

namespace Tasks.App.CQRS.Commands.Tokens.AddToken
{
    public class AddTokenCommandHandler : IRequestHandler<AddTokenCommand, AddTokenCommandResult>
    {
        private readonly IJWTTokenService _jWTTokenService;

        public AddTokenCommandHandler(IJWTTokenService jWTTokenService)
        {
            _jWTTokenService = jWTTokenService;
        }

        public async Task<AddTokenCommandResult> Handle(AddTokenCommand request, CancellationToken cancellationToken)
        {
            return await _jWTTokenService.AddTokenAsync(request);
        }
    }
}
