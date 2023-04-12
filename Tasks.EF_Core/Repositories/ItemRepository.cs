using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tasks.App.Repositories;
using Tasks.Domain.Models;
using Tasks.EF_Core.Context;
using Tasks.EF_Core.Dbo;

namespace Tasks.EF_Core.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly TasksContext _context;
        private readonly IMapper _mapper;

        public ItemRepository(TasksContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ItemComposite?> ChangeItemStateAsync(int itemId, ItemState newState)
        {
            var item = await _context.Items.FirstOrDefaultAsync(i => i.Id == itemId);

            if(item == null)
            {
                return null;
            }

            item.State = newState;
            var res = await _context.SaveChangesAsync();

            if(res == 0)
            {
                return null;
            }
            
            return _mapper.Map<ItemComposite>(item);
        }

        public async Task<ItemComposite> CreateItemAsync(int userId, int boardId, string name)
        {
            var item = new ItemDbo()
            {
                Name = name,
                BoardId = boardId,
                CreatedById = userId,
                State = ItemState.OnHold,
            };

            var res = await _context.Items.AddAsync(item);
            await _context.SaveChangesAsync();  

            return _mapper.Map<ItemComposite>(res.Entity);
        }
    }
}
