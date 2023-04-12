using Tasks.App.CQRS.Commands.Boards.AddUserToBoard;
using Tasks.App.CQRS.Commands.Boards.ChangeBoardName;
using Tasks.App.CQRS.Commands.Boards.CreateBoard;
using Tasks.App.CQRS.Commands.Boards.RemoveBoard;
using Tasks.App.CQRS.Commands.Boards.RemoveUserFromBoard;
using Tasks.App.CQRS.Queries.Boards.GetUserBoardById;
using Tasks.App.CQRS.Queries.Boards.GetUserBoards;
using Tasks.App.Repositories;
using Tasks.App.Services;

namespace Tasks.Infrastructure.Services
{
    public class BoardService : IBoardService
    {
        private readonly IBoardRepository _boardRepository;

        public BoardService(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public async Task<GetUserBoardsQueryResult> GetUserBoardsAsync(GetUserBoardsQuery query)
        {
            var boards = await _boardRepository.GetBoardsByUserIdAsync(query.UserId);
            return new GetUserBoardsQueryResult(boards);
        }

        public async Task<CreateBoardCommandResult> CreateBoardAsync(CreateBoardCommand request)
        {
            var board = await _boardRepository.CreateBoardAsync(request.UserId, request.Name);
            return new CreateBoardCommandResult(board);
        }

        public async Task<AddUserToBoardCommandResult> AddUserToBoardAsync(AddUserToBoardCommand request)
        {
            var valRes = await IsUserOwner(request.BoardId, request.UserId);
            if (!valRes)
            {
                return new AddUserToBoardCommandResult(false, null);
            }

            var board = await _boardRepository.AddUserToBoardAsync(request.BoardId, request.UserIdToAdd);
            return new AddUserToBoardCommandResult(board != null, board);
        }

        public async Task<ChangeBoardNameCommandResult> ChangeBoardNameAsync(ChangeBoardNameCommand request)
        {
            var valRes = await IsUserOwner(request.BoardId, request.UserId);
            if (!valRes)
            {
                return new ChangeBoardNameCommandResult(false, null);
            }

            var board = await _boardRepository.ChangeBoardNameAsync(request.BoardId, request.NewName);
            return new ChangeBoardNameCommandResult(board != null, board);
        }

        public async Task<GetUserBoardByIdQueryResult> GetUserBoardByIdAsync(GetUserBoardByIdQuery query)
        {
            var board = await _boardRepository.GetBoardByIdAsync(query.BoardId);

            if (await IsUserOwner(query.BoardId, query.UserId))
            {
                return new GetUserBoardByIdQueryResult(true, board);
            }

            if (await IsUserShared(query.BoardId, query.UserId))
            {
                return new GetUserBoardByIdQueryResult(true, board);
            }

            return new GetUserBoardByIdQueryResult(false, null);
        }

        public Task<RemoveBoardCommandResult> RemoveBoardAsync(RemoveBoardCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<RemoveUserFromBoardCommandResult> RemoveUserFromBoardAsync(RemoveUserFromBoardCommand request)
        {
            throw new NotImplementedException();
        }


        //TODO: Move to new class
        private async Task<bool> IsUserOwner(int boardId, int userId)
        {
            var board = await _boardRepository.GetBoardByIdAsync(boardId);
            return board != null && board.Owner.Id.Equals(userId);
        }

        private async Task<bool> IsUserShared(int boardId, int userId)
        {
            var board = await _boardRepository.GetBoardByIdAsync(boardId);
            return board != null && board.SharedUsers.Any(u => u.Id.Equals(userId));
        }


        public async Task<bool> IsUserOwnerBoardAsync(int boardId, int userId)
        {
            return await IsUserOwner(boardId, userId);
        }

        public async Task<bool> IsUserSharedAsync(int boardId, int userId)
        {
            return await IsUserShared(boardId, userId);
        }

        public async Task<bool> IsUserInBoardAsync(int boardId, int userId)
        {
            return await IsUserOwner(boardId, userId) || await IsUserShared(boardId, userId);
        }
    }
}
