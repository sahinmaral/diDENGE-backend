namespace diDENGE.Application.Services.MailService;

public interface IMailService
{
    Task SendMailAsync(string email, string subject, string body);
}