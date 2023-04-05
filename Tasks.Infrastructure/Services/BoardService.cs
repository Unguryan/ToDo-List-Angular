using Tasks.App.CQRS.Commands.Board.AddUserToBoard;
using Tasks.App.CQRS.Commands.Board.ChangeBoardName;
using Tasks.App.CQRS.Commands.Board.CreateBoard;
using Tasks.App.CQRS.Commands.Board.RemoveBoard;
using Tasks.App.CQRS.Commands.Board.RemoveUserFromBoard;
using Tasks.App.CQRS.Queries.Board.GetUserBoardById;
using Tasks.App.CQRS.Queries.Board.GetUserBoards;
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
