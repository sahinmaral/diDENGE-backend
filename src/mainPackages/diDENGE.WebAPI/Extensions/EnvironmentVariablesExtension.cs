using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace diDENGE.WebAPI.Extensions;

public static class EnvironmentVariablesExtension
{
    public static void ConfigureEnvironmentVariables(this WebApplicationBuilder builder)
    {
        var environment = builder.Environment;
        var configuration = builder.Configuration;
        
        if (environment.IsProduction())
        {
            AddSecretKeysForProductionEnvironment(configuration);
        }
        else if (environment.IsEnvironment("Docker"))
        {
            AddSecretKeysForDockerEnvironment(configuration);
        }
    }

    private static void AddSecretKeysForDockerEnvironment(IConfiguration configuration)
    {
        configuration["ConnectionStrings:MSSQLConnectionString"] = Environment.GetEnvironmentVariable("MSSQLConnectionString");
        configuration["Cloudinary:CloudName"] = Environment.GetEnvironmentVariable("CloudinaryCloudName");
        configuration["Cloudinary:APIKey"] = Environment.GetEnvironmentVariable("CloudinaryApiKey");
        configuration["Cloudinary:APISecret"] = Environment.GetEnvironmentVariable("CloudinaryApiSecret");
        configuration["SendGrid:APIKey"] = Environment.GetEnvironmentVariable("SendGridApiKey");
        configuration["SendGrid:MailAccount"] = Environment.GetEnvironmentVariable("SendGridMailAccount");
    }
    

    private static void AddSecretKeysForProductionEnvironment(ConfigurationManager configuration)
    {
        var keyVaultUrl = configuration["KeyVault:KeyVaultURL"];
    
        configuration.AddAzureKeyVault(new Uri(keyVaultUrl), new DefaultAzureCredential());

        try
        {
            var client = new SecretClient(new Uri(keyVaultUrl), new DefaultAzureCredential());
        
            KeyVaultSecret mssqlConnectionStringSecret = client.GetSecret("MSSQLConnectionString");
            string mssqlConnectionStringSecretValue = mssqlConnectionStringSecret.Value;
            configuration["ConnectionStrings:MSSQLConnectionString"] = mssqlConnectionStringSecretValue;
        
            KeyVaultSecret cloudinaryCloudNameSecret = client.GetSecret("CloudinaryCloudName");
            string cloudinaryCloudNameSecretValue = cloudinaryCloudNameSecret.Value;
            configuration["Cloudinary:CloudName"] = cloudinaryCloudNameSecretValue;
        
            KeyVaultSecret cloudinaryApiKeySecret = client.GetSecret("CloudinaryApiKey");
            string cloudinaryApiKeySecretValue = cloudinaryApiKeySecret.Value;
            configuration["Cloudinary:APIKey"] = cloudinaryApiKeySecretValue;
        
            KeyVaultSecret cloudinaryApiSecretSecret = client.GetSecret("CloudinaryApiSecret");
            string cloudinaryApiSecretSecretValue = cloudinaryApiSecretSecret.Value;
            configuration["Cloudinary:APISecret"] = cloudinaryApiSecretSecretValue;
        
            KeyVaultSecret jwtSecurityKeySecret = client.GetSecret("JWTSecurityKey");
            string jwtSecurityKeySecretValue = jwtSecurityKeySecret.Value;
            configuration["JwtOptions:SecurityKey"] = jwtSecurityKeySecretValue;
            
            KeyVaultSecret sendGridApiKeySecret = client.GetSecret("SendGridApiKey");
            string sendGridApiKeySecretValue = sendGridApiKeySecret.Value;
            configuration["SendGrid:ApiKey"] = sendGridApiKeySecretValue;
            
            KeyVaultSecret sendGridMailAccountSecret = client.GetSecret("SendGridMailAccount");
            string sendGridMailAccountSecretValue = sendGridMailAccountSecret.Value;
            configuration["SendGrid:MailAccount"] = sendGridMailAccountSecretValue;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error retrieving secret from Key Vault: {ex.Message}");
            throw;
        }
    }
}