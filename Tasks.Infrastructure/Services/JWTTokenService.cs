using Tasks.App.CQRS.Commands.Tokens.AddToken;
using Tasks.App.CQRS.Commands.Tokens.RemoveToken;
using Tasks.App.CQRS.Queries.Tokens.GetActiveUserToken;
using Tasks.App.CQRS.Queries.Tokens.ReadToken;
using Tasks.App.Repositories;
using Tasks.App.Services;

namespace Tasks.Infrastructure.Services
{
    public class JWTTokenService : IJWTTokenService
    {
        private readonly IJWTTokenGenerator _jWTTokenGenerator;

        private readonly ITokenRepository _tokenRepository;

        public JWTTokenService(IJWTTokenGenerator jWTTokenGenerator, ITokenRepository tokenRepository)
        {
            _jWTTokenGenerator = jWTTokenGenerator;
            _tokenRepository = tokenRepository;
        }

        public async Task<AddTokenCommandResult> AddTokenAsync(AddTokenCommand request)
        {
            var activeToken = await _tokenRepository.GetActiveTokenByUserIdAsync(request.User.Id);

            if(activeToken != null)
            {
                await _tokenRepository.RemoveTokenAsync(activeToken.TokenData);
            }

            var tokenData = await _jWTTokenGenerator.GenerateTokenAsync(request.User);
            var token = await _tokenRepository.AddTokenAsync(tokenData, request.User);

            return new AddTokenCommandResult(token);
        }

        public async Task<GetActiveUserTokenQueryResult> GetActiveUserTokenAsync(GetActiveUserTokenQuery query)
        {
            var activeToken = await _tokenRepository.GetActiveTokenByUserIdAsync(query.UserId);
            return new GetActiveUserTokenQueryResult(activeToken != null, activeToken);
        }

        public async Task<ReadTokenQueryResult> ReadTokenAsync(ReadTokenQuery query)
        {
            var token = await _tokenRepository.GetTokenByTokenDataAsync(query.TokenData);
            return new ReadTokenQueryResult(token?.User);
        }

        public async Task<RemoveTokenCommandResult> RemoveTokenAsync(RemoveTokenCommand request)
        {
            var activeToken = await _tokenRepository.GetActiveTokenByUserIdAsync(request.UserId);

            if (activeToken != null && activeToken.TokenData.Equals(request.TokenData))
            {
                var res = await _tokenRepository.RemoveTokenAsync(request.TokenData);
                return new RemoveTokenCommandResult(res != null, res);
            }

            return new RemoveTokenCommandResult(false, null);
        }
    }
}
