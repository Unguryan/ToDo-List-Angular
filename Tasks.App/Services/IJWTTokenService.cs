namespace Tasks.App.Services
{
    public interface IJWTTokenService
    {
        Task<ReadTokenQueryResult> ReadTokenAsync(ReadTokenQuery query);

        Task<AddTokenCommandResult> AddTokenAsync(AddTokenCommand request);

        Task<RemoveTokenCommandResult> RemoveTokenAsync(RemoveTokenCommand request);
    }
}
