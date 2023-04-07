using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using Tasks.App.CQRS.Commands.Users.NotifyUser;
using Tasks.App.Services;
using Tasks.Domain.Events;
using Tasks.Notifications.Hubs;

namespace Tasks.Notifications.Services
{
    public class NotifyUserService : INotifyUserService
    {
        private readonly IHubContext<NotifyUsersHub> _hub;

        private readonly ILogger _logger;

        public NotifyUserService(IHubContext<NotifyUsersHub> hub, ILogger<NotifyUserService> logger)
        {
            _hub = hub;
            _logger = logger;
        }

        public async Task<NotifyUserCommandResult> NotifyUserAsync(NotifyUserCommand request)
        {
            var isSend = false;

            if (request.Event is AuthErrorEvent)
            {
                isSend = await SendAuthErrorEvent((AuthErrorEvent)request.Event);
            }

            if (request.Event is LoggedByTelegramEvent)
            {
                isSend = await SendLoggedByTelegramEvent((LoggedByTelegramEvent)request.Event);
            }

            return new NotifyUserCommandResult(isSend);
        }

        private async Task<bool> SendAuthErrorEvent(AuthErrorEvent @event)
        {
            return await SendData("AuthErrorNotification", JsonSerializer.Serialize(@event));
        }

        private async Task<bool> SendLoggedByTelegramEvent(LoggedByTelegramEvent @event)
        {
            return await SendData("LoggedByTelegramNotification", JsonSerializer.Serialize(@event));
        }

        private async Task<bool> SendData(string EventName, string EventData)
        {
            try
            {
                await _hub.Clients.All.SendAsync(EventName, EventData);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return false;
            }

            return true;
        }
    }
}
