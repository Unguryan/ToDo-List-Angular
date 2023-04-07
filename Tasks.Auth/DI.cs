using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tasks.App.Services;
using Tasks.Auth.Services;

namespace Tasks.Auth
{
    public static class DI
    {
        public static void AddAuth(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAuthLinkGenerator, AuthLinkGenerator>();
            services.AddScoped<IAuthLinkService, AuthLinkService>();
            services.AddScoped<IAuthUserService, AuthUserService>();
        }
    }
}
