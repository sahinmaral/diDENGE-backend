using diDENGE.Application.Features.Auths.Rules;
using diDENGE.Application.Services.MessageService;
using MediatR;

namespace diDENGE.Application.Features.Auths.Commands.SendVerificationCode;

public class SendVerificationCodeCommand : IRequest
{
    public string UserId { get; set; }
    
    public sealed class SendVerificationCodeCommandHandler(AuthBusinessRules authBusinessRules,IMessageService messageService) : IRequestHandler<SendVerificationCodeCommand>
    {
        public async Task Handle(SendVerificationCodeCommand request, CancellationToken cancellationToken)
        {
            var foundUser = await authBusinessRules.CheckUserExistsById(request.UserId);
            var result = await messageService.SendVerificationCodeAsync(foundUser.PhoneNumber);
            if (!result)
                throw new ArgumentException("Error sending verification code");
        }
    }
}