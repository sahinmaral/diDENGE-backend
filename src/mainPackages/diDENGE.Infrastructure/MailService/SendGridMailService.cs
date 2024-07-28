using System.Text.RegularExpressions;
using diDENGE.Application.Services.MailService;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace diDENGE.Infrastructure.MailService;

public class SendGridMailService : IMailService
{
    private readonly IConfiguration _configuration;

    public SendGridMailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task SendMailAsync(string email, string subject, string body)
    {
        var client = new SendGridClient(_configuration["SendGrid:APIKey"]);

        var from = new EmailAddress(_configuration["SendGrid:MailAccount"], "didenge");
        var to = new EmailAddress(_configuration["SendGrid:MailAccount"], "didenge");

        var strippedHtmlContent = StripHtmlTags("test");
        var msg = MailHelper.CreateSingleEmail(from, to, subject, strippedHtmlContent, body);
        var response = await client.SendEmailAsync(msg);
        
    }

    private string StripHtmlTags(string input)
    {
        return Regex.Replace(input, "<.*?>", string.Empty);
    }
}