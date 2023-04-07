using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Tasks.Domain.Options;
using Tasks.Telegram.Services.Interfaces;
using Tasks.Telegram.Services;
using Telegram.Bot;

namespace Tasks.Auth
{
    public static class DI
    {
        public static void AddTelegramBot(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient("telegram_bot_client")
               .AddTypedClient<ITelegramBotClient>((httpClient, sp) =>
               {
                   var botConfig = sp.GetService<IOptions<TelegramBotOptions>>();
                   TelegramBotClientOptions options = new(botConfig.Value.BotToken);
                   return new TelegramBotClient(options, httpClient);
               });

            services.AddScoped<ITelegramMessageService, TelegramMessageService>();
            services.AddScoped<UpdateHandler>();

            services.AddHostedService<ConfigureWebhook>();

            services.AddControllersWithViews().AddNewtonsoftJson();
        }
    }
}
