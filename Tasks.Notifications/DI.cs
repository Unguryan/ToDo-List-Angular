using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tasks.App.Services;
using Tasks.Notifications.Services;

namespace Tasks.Notifications
{
    public static class DI
    {
        public static void AddNotifications(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<INotifyUserService, NotifyUserService>();
            services.AddSignalR();
        }
    }
}
