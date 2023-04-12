using Tasks.App.CQRS.Commands.Boards.AddUserToBoard;
using Tasks.App.CQRS.Commands.Boards.ChangeBoardName;
using Tasks.App.CQRS.Commands.Boards.CreateBoard;
using Tasks.App.CQRS.Commands.Boards.RemoveBoard;
using Tasks.App.CQRS.Commands.Boards.RemoveUserFromBoard;
using Tasks.App.CQRS.Queries.Boards.GetUserBoardById;
using Tasks.App.CQRS.Queries.Boards.GetUserBoards;

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

        Task<bool> IsUserInBoardAsync(int boardId, int userId);
        Task<bool> IsUserOwnerBoardAsync(int boardId, int userId);
        Task<bool> IsUserSharedAsync(int boardId, int userId);
    }
}
