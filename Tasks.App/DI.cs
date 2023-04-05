using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Tasks.App
{
    public static class DI
    {
        public static void AddAssembly(this IServiceCollection services)
        {
            var assebmly = Assembly.GetExecutingAssembly();

            services.AddMediatR(assebmly);
        }
    }
}
