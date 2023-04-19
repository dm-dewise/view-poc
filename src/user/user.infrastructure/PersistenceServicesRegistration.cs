using Microsoft.Extensions.DependencyInjection;
using user.application.Contracts.Persistence;
using user.infrastructure.Repositories;

namespace user.infrastructure
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigureUserPersistenceServices(this IServiceCollection services)
        {            
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();

            return services;
        }
    }
}
