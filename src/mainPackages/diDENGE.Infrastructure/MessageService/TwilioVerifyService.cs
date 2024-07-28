using diDENGE.Application.Services.MessageService;
using Microsoft.Extensions.Configuration;
using Twilio;
using Twilio.Rest.Verify.V2.Service;

namespace diDENGE.Infrastructure.MessageService;

public class TwilioVerifyService: IMessageService
{
    private readonly string _accountSid;
    private readonly string _authToken;
    private readonly string _verifyServiceSid;

    public TwilioVerifyService(IConfiguration configuration)
    {
        _accountSid = configuration["Twilio:AccountSID"];
        _authToken = configuration["Twilio:AuthToken"];
        _verifyServiceSid = configuration["Twilio:VerifyServiceSID"];
        TwilioClient.Init(_accountSid, _authToken);
    }

    public async Task<bool> SendVerificationCodeAsync(string phoneNumber)
    {
        var verification = await VerificationResource.CreateAsync(
            to: phoneNumber,
            channel: "sms",
            pathServiceSid: _verifyServiceSid
        );
        
        return verification != null && verification.Status == "pending";
    }

    public async Task<bool> VerifyCodeAsync(string phoneNumber, string code)
    {
        var verificationCheck = await VerificationCheckResource.CreateAsync(
            to: phoneNumber,
            code: code,
            pathServiceSid: _verifyServiceSid
        );
        
        return verificationCheck != null && verificationCheck.Status == "approved";
    }
}