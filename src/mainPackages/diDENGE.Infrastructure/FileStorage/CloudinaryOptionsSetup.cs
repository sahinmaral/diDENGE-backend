using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace diDENGE.Infrastructure.FileStorage;

public sealed class CloudinaryOptions
{
    public string CloudName { get; set; } = null!;
    public string APIKey { get; set; } = null!;
    public string APISecret { get; set; } = null!;
}
public sealed class CloudinaryOptionsSetup : IConfigureOptions<CloudinaryOptions>
{
    private readonly IConfiguration _configuration;
    private readonly IWebHostEnvironment _environment;

    public CloudinaryOptionsSetup(IConfiguration configuration, IWebHostEnvironment environment)
    {
        _configuration = configuration;
        _environment = environment;
    }

    public void Configure(CloudinaryOptions options)
    {
        if (_environment.IsDevelopment())
        {
            _configuration.GetSection("Cloudinary").Bind(options);
        }
        if (_environment.IsProduction())
        {
            options.CloudName = Environment.GetEnvironmentVariable("CLOUDINARY_CLOUD_NAME");
            options.APIKey = Environment.GetEnvironmentVariable("CLOUDINARY_API_KEY");
            options.APISecret = Environment.GetEnvironmentVariable("CLOUDINARY_API_SECRET");
        }
    }
}