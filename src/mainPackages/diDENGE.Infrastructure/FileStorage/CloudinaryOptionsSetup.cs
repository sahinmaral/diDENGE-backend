using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
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
        _configuration.GetSection("Cloudinary").Bind(options);
    }
}