using System.Text.RegularExpressions;
using FluentValidation;

namespace diDENGE.Application.Features.Auths.Commands.SendVerificationCode;

public class SendVerificationCodeCommandValidator : AbstractValidator<SendVerificationCodeCommand>
{
    public SendVerificationCodeCommandValidator()
    {
        RuleFor(u => u.UserId).NotEmpty();
    }
}