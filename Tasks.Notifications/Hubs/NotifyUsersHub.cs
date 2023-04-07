﻿using Microsoft.AspNetCore.SignalR;

namespace Tasks.Notifications.Hubs
{
    public class NotifyUsersHub : Hub
    {
        public async Task SendLoginNotification(string data)
        {
            await Clients.All.SendAsync("ReceiveLoginNotification", data);
        }
    }
}
