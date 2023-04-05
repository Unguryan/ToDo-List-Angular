using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tasks.App.Repositories;
using Tasks.EF_Core.Context;
using Tasks.EF_Core.Repositories;

namespace Tasks.EF_Core
{
    public static class DI
    {
        public static void AddEF_Core(this IServiceCollection services, IConfiguration configuration)
        {
            var assebmly = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assebmly);

            services.AddDbContext<TasksContext>();

            services.AddScoped<IBoardRepository, BoardRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<ITokenRepository, TokenRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
