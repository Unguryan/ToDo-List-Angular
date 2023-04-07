using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tasks.App.Repositories;
using Tasks.Domain.Models;
using Tasks.EF_Core.Context;
using Tasks.EF_Core.Dbo;

namespace Tasks.EF_Core.Repositories
{
    public class TokenRepository : ITokenRepository
    {
        private readonly TasksContext _context;
        private readonly IMapper _mapper;

        public TokenRepository(TasksContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Token> AddTokenAsync(string tokenData, User user)
        {
            var token = await GetActiveTokenByUserId(user.Id);

            if(token != null && token.ExpiredAt < DateTime.Now)
            {
                return token;
            }

            var addedToken = await _context.Tokens.AddAsync(new TokenDbo()
            {
                TokenData = tokenData,
                ExpiredAt = DateTime.Now.AddDays(7),
                UserId = user.Id
            });

            await _context.SaveChangesAsync();

            var resToken = _mapper.Map<Token>(addedToken.Entity);
            if (resToken != null)
            {
                resToken.User = user;
            }

            return resToken;
        }

        public async Task<Token?> GetActiveTokenByUserId(int id)
        {
            var tokenDbo = await _context.Tokens.FirstOrDefaultAsync(t => t.UserId == id);
            var token = _mapper.Map<Token>(tokenDbo);
            if(token != null)
            {
                token.User = _mapper.Map<User>(tokenDbo?.User);
            }
            return token;
        }

        public async Task<Token?> RemoveTokenAsync(string tokenData)
        {
            var tokenDbo = await _context.Tokens.FirstOrDefaultAsync(t => t.TokenData.Equals(tokenData));
            if(tokenDbo == null)
            {
                return null;
            }

            var res = _context.Tokens.Remove(tokenDbo);
            await _context.SaveChangesAsync();

            var token = _mapper.Map<Token>(res.Entity);
            if (token != null)
            {
                token.User = _mapper.Map<User>(res.Entity?.User);
            }
            return token;
        }
    }
}
