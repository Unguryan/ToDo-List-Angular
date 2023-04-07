using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tasks.App;
using Tasks.App.Services;
using Tasks.Infrastructure.Services;

namespace Tasks.Infrastructure
{
    public static class DI
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAssembly(configuration);

            services.AddScoped<IBoardService, BoardService>();
            services.AddScoped<IItemService, ItemService>();
            services.AddScoped<IJWTTokenGenerator, JWTTokenGenerator>();
            services.AddScoped<IJWTTokenService, JWTTokenService>();
            services.AddScoped<INotifyUserService, NotifyUserService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
