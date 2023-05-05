using Emerson.WeatherSystem.Application.Contracts.Persistence;
using Emerson.WeatherSystem.Persistence.Repositories;
using GSM.APCM.Apparel.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Emerson.WeatherSystem.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddDbContext<EmersonWeatherSystemDbContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("emerson-db-ConnectionString"));
            });

            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IVariableRepository, VariableRepository>();

            return services;
        }
    }
}
