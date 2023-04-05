using Tasks.App.CQRS.Commands.Board.AddUserToBoard;
using Tasks.App.CQRS.Commands.Board.ChangeBoardName;
using Tasks.App.CQRS.Commands.Board.CreateBoard;
using Tasks.App.CQRS.Commands.Board.RemoveBoard;
using Tasks.App.CQRS.Commands.Board.RemoveUserFromBoard;
using Tasks.App.CQRS.Queries.Board.GetUserBoardById;
using Tasks.App.CQRS.Queries.Board.GetUserBoards;

namespace Tasks.App.Services
{
    public interface IBoardService
    {
        Task<GetUserBoardsQueryResult> GetUserBoardsAsync(GetUserBoardsQuery query);

        Task<GetUserBoardByIdQueryResult> GetUserBoardByIdAsync(GetUserBoardByIdQuery query);

        Task<CreateBoardCommandResult> CreateBoardAsync(CreateBoardCommand request);

        Task<RemoveBoardCommandResult> RemoveBoardAsync(RemoveBoardCommand request);

        Task<ChangeBoardNameCommandResult> ChangeBoardNameAsync(ChangeBoardNameCommand request);

        Task<AddUserToBoardCommandResult> AddUserToBoardAsync(AddUserToBoardCommand request);

        Task<RemoveUserFromBoardCommandResult> RemoveUserFromBoardAsync(RemoveUserFromBoardCommand request);
    }
}
