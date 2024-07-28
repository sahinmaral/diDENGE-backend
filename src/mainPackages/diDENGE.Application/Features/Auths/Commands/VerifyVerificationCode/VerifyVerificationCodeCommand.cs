using Core.CrossCuttingConcerns.Exceptions;
using Core.Security.Entities;
using diDENGE.Application.Features.Auths.Rules;
using diDENGE.Application.Services.MessageService;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace diDENGE.Application.Features.Auths.Commands.VerifyVerificationCode;

public class VerifyVerificationCodeCommand : IRequest
{
    public string Code { get; set; }
    public string UserId { get; set; }
    
    public sealed class VerifyVerificationCodeCommandHandler(AuthBusinessRules authBusinessRules,IMessageService messageService, UserManager<User> userManager) : IRequestHandler<VerifyVerificationCodeCommand>
    {
        public async Task Handle(VerifyVerificationCodeCommand request, CancellationToken cancellationToken)
        {
            var foundUser = await authBusinessRules.CheckUserExistsById(request.UserId);
            var result = await messageService.VerifyCodeAsync(foundUser.PhoneNumber,request.Code);
            if (!result)
                throw new BusinessException("Verification code is expired");

            foundUser.PhoneNumberConfirmed = true;
            await userManager.UpdateAsync(foundUser);
        }
    }
}