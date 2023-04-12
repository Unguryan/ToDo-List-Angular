using MediatR;
using Tasks.App.Services;

namespace Tasks.App.CQRS.Queries.Tokens.ReadToken
{
    public class ReadTokenQueryHandler : IRequestHandler<ReadTokenQuery, ReadTokenQueryResult>
    {
        private readonly IJWTTokenService _jWTTokenService;

        public ReadTokenQueryHandler(IJWTTokenService jWTTokenService)
        {
            _jWTTokenService = jWTTokenService;
        }

        public async Task<ReadTokenQueryResult> Handle(ReadTokenQuery request, CancellationToken cancellationToken)
        {
            return await _jWTTokenService.ReadTokenAsync(request);
        }
    }
}
