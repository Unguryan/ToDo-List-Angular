namespace Tasks.Domain.Events
{
    public record AuthErrorEvent(string AuthCode, string? ErrorMessage) : IBaseEvent; 
}
