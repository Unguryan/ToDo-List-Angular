using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tasks.Domain.Options;

namespace Tasks.App
{
    public static class DI
    {
        public static void AddAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var assebmly = Assembly.GetExecutingAssembly();
            services.AddMediatR(assebmly);

            var telegramOption = configuration.GetSection(TelegramBotOptions.SectionName);
            services.AddOptions<TelegramBotOptions>()
                    .Bind(telegramOption);
        }
    }
}
