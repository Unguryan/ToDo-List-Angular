using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using TelegramUser = Telegram.Bot.Types.User;
using User = Tasks.Domain.Models.User;

namespace Tasks.Telegram
{
    public static class TelegramExtensions
    {
        public static ControllerActionEndpointConventionBuilder MapBotWebhookRoute<T>(
            this IEndpointRouteBuilder endpoints,
            string route)
        {
            var controllerName = typeof(T).Name.Replace("Controller", "");
            var actionName = typeof(T).GetMethods()[0].Name;

            return endpoints.MapControllerRoute(
                name: "bot_webhook",
                pattern: route,
                defaults: new { controller = controllerName, action = actionName });
        }
    }
}
