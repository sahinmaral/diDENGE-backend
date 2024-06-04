using diDENGE.Application.Services.FileStorage;
using diDENGE.Application.Services.MailService;
using diDENGE.Application.Services.MessageService;
using diDENGE.Infrastructure.FileStorage;
using diDENGE.Infrastructure.MailService;
using diDENGE.Infrastructure.MessageService;
using Microsoft.Extensions.DependencyInjection;

namespace diDENGE.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton<ICloudinaryService, CloudinaryService>();
        services.AddSingleton<IMailService, SendGridMailService>();
        services.AddSingleton<IMessageService, TwilioVerifyService>();

        services.ConfigureOptions<CloudinaryOptionsSetup>();

        return services;
    }
}