namespace Tasks.Domain.Events
{
    public record LoggedByTelegramEvent(string AuthCode, string TokenData) : IBaseEvent; 
}
