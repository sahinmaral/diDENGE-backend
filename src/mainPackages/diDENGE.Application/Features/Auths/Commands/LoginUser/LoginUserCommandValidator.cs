using FluentValidation;

namespace diDENGE.Application.Features.Auths.Commands.LoginUser;

public class LoginUserCommandValidator : AbstractValidator<LoginUserCommand>
{
    public LoginUserCommandValidator()
    {
        RuleFor(x => x.UsernameOrEmail)
            .NotEmpty();
        
        RuleFor(x => x.Password)
            .NotEmpty();
    }
}