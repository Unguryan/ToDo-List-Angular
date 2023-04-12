using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using Tasks.App.Repositories;
using Tasks.Domain.Models;
using Tasks.EF_Core.Context;
using Tasks.EF_Core.Dbo;

namespace Tasks.EF_Core.Repositories
{
    public class BoardRepository : IBoardRepository
    {
        private readonly TasksContext _context;
        private readonly IMapper _mapper;

        public BoardRepository(TasksContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<Board?> AddUserToBoardAsync(int boardId, int userIdToAdd)
        {
            throw new NotImplementedException();
        }

        public Task<Board?> ChangeBoardNameAsync(int boardId, string newName)
        {
            throw new NotImplementedException();
        }

        public async Task<Board> CreateBoardAsync(int userId, string name)
        {
            BoardDbo? existingBoard = null;
            do
            {
                existingBoard = await _context.Boards.FirstOrDefaultAsync(b => b.OwnerId == userId && b.Name.Equals(name));
                if (existingBoard != null)
                {
                    name += " (1)";
                }
            }
            while (existingBoard != null);

            var boardDbo = new BoardDbo()
            {
                Name = name,
                OwnerId = userId,
                Items = new List<ItemDbo>(),
                SharedUsers = new List<UserDbo>()
            };

            var resEntity = await _context.Boards.AddAsync(boardDbo);
            await _context.SaveChangesAsync();

            var resBoard = _mapper.Map<Board>(resEntity.Entity);

            return resBoard;
        }

        public async Task<Board?> GetBoardByIdAsync(int boardId)
        {
            var board = await _context.Boards.Include(b => b.Items).FirstOrDefaultAsync(b => b.Id == boardId);
            return _mapper.Map<Board>(board);
        }

        public async Task<List<Board>?> GetBoardsByUserIdAsync(int userId)
        {
            var boards = new List<Board>();

            var boardsDbo = _context.Boards.Where(b => b.OwnerId == userId);

            await boardsDbo.ForEachAsync(b => boards.Add(_mapper.Map<Board>(b)));

            return boards;
        }
    }
}
