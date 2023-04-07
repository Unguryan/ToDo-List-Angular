using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tasks.App.Repositories;
using Tasks.Domain.Models;
using Tasks.EF_Core.Context;
using Tasks.EF_Core.Dbo;

namespace Tasks.EF_Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TasksContext _context;
        private readonly IMapper _mapper;

        public UserRepository(TasksContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<User> AddUserAsync(string name, string? telegramId = "", string? gitHubUserName = "")
        {
            User? user = null;

            if (!string.IsNullOrEmpty(telegramId))
            {
                user = await GetUserByTelegramIdAsync(telegramId);
            }

            if (!string.IsNullOrEmpty(gitHubUserName))
            {
                user = await GetUserByTelegramIdAsync(telegramId);
            }

            if(user != null)
            {
                return user;
            }

            var res = await _context.Users.AddAsync(new UserDbo()
            {
                Name = name,
                TelegramId = telegramId,
                GitHubUserName = gitHubUserName,
                Username = string.Empty
            });

            await _context.SaveChangesAsync();

            return _mapper.Map<User>(res.Entity);
        }

        public async Task<bool> IsFreeUsername(string username)
        {
            return !await _context.Users.AnyAsync(u => u.Username.ToLower().Equals(username.ToLower()));
        }

        public async Task<bool> AddUsername(int userId, string username)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id.Equals(userId));

            if(user == null)
            {
                return false;
            }

            user.Username = username;
            var res = await _context.SaveChangesAsync();

            return res > 0;
        }

        public async Task<User?> GetUserByHubUserNameAsync(string gitHubUserName)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.GitHubUserName.ToLower().Equals(gitHubUserName.ToLower()));
            return _mapper.Map<User>(user);
        }

        public async Task<User?> GetUserByTelegramIdAsync(string telegramId)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.TelegramId.Equals(telegramId));
            return _mapper.Map<User>(user);
        }
    }
}
