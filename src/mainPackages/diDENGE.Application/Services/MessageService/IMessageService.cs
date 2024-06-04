namespace diDENGE.Application.Services.MessageService;

public interface IMessageService
{
    Task<bool> SendVerificationCodeAsync(string phoneNumber);
    Task<bool> VerifyCodeAsync(string phoneNumber, string code);
}