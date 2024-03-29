using diDENGE.Application.Services.FileStorage;
using diDENGE.Infrastructure.FileStorage;
using Microsoft.Extensions.DependencyInjection;

namespace diDENGE.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton<ICloudinaryService, CloudinaryService>();

        services.ConfigureOptions<CloudinaryOptionsSetup>();

        return services;
    }
}