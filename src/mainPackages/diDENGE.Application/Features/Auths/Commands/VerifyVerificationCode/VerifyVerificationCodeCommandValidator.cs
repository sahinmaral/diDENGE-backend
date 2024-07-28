using diDENGE.Application.Features.Auths.Commands.SendVerificationCode;
using FluentValidation;

namespace diDENGE.Application.Features.Auths.Commands.VerifyVerificationCode;

public class VerifyVerificationCodeCommandValidator : AbstractValidator<VerifyVerificationCodeCommand>
{
    public VerifyVerificationCodeCommandValidator()
    {
        RuleFor(u => u.Code).NotEmpty();
        RuleFor(u => u.Code).MinimumLength(6);
        RuleFor(u => u.Code).MaximumLength(6);
        
        
        RuleFor(u => u.UserId).NotEmpty();
    }
}