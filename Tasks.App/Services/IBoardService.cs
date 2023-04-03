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
