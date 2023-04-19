using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using user.application.Contracts.Persistence;

namespace user.application
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection ConfigureUserApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
