using diDENGE.Application.Services.Repositories;
using diDENGE.Persistance.Context;
using diDENGE.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace diDENGE.Persistance;

public static class PersistanceServiceRegistration
{
    public static IServiceCollection AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("MSSQLConnectionString");

        services.AddScoped<IAddictionLevelRepository, AddictionLevelRepository>();
        services.AddScoped<IUserAddictionLevelRepository, UserAddictionLevelRepository>();
        services.AddScoped<IWordOfTheDayRepository, WordOfTheDayRepository>();
        services.AddScoped<IProcedurePointInformationRepository, ProcedurePointInformationRepository>();
        services.AddScoped<IProcedureRepository, ProcedureRepository>();
        services.AddScoped<ISocialMediaApplicationRepository, SocialMediaApplicationRepository>();
        services.AddScoped<ISocialMediaApplicationUsageRepository, SocialMediaApplicationUsageRepository>();
        

        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        return services;
    }
}