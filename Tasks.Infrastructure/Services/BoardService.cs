using Tasks.App.CQRS.Commands.Boards.AddUserToBoard;
using Tasks.App.CQRS.Commands.Boards.ChangeBoardName;
using Tasks.App.CQRS.Commands.Boards.CreateBoard;
using Tasks.App.CQRS.Commands.Boards.RemoveBoard;
using Tasks.App.CQRS.Commands.Boards.RemoveUserFromBoard;
using Tasks.App.CQRS.Queries.Boards.GetUserBoardById;
using Tasks.App.CQRS.Queries.Boards.GetUserBoards;
using Tasks.App.Services;

namespace Tasks.Infrastructure.Services
{
    public class BoardService : IBoardService
    {
        public Task<AddUserToBoardCommandResult> AddUserToBoardAsync(AddUserToBoardCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<ChangeBoardNameCommandResult> ChangeBoardNameAsync(ChangeBoardNameCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateBoardCommandResult> CreateBoardAsync(CreateBoardCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<GetUserBoardByIdQueryResult> GetUserBoardByIdAsync(GetUserBoardByIdQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<GetUserBoardsQueryResult> GetUserBoardsAsync(GetUserBoardsQuery query)
        {
            throw new NotImplementedException();
        }

        public Task<RemoveBoardCommandResult> RemoveBoardAsync(RemoveBoardCommand request)
        {
            throw new NotImplementedException();
        }

        public Task<RemoveUserFromBoardCommandResult> RemoveUserFromBoardAsync(RemoveUserFromBoardCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
