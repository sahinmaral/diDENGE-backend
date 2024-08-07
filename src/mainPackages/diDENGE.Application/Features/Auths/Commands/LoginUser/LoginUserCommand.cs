using AutoMapper;
using Core.Security.Entities;
using Core.Security.JWT;
using diDENGE.Application.Features.Auths.Dtos;
using diDENGE.Application.Features.Auths.Rules;
using diDENGE.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace diDENGE.Application.Features.Auths.Commands.LoginUser;

public class LoginUserCommand : IRequest<LoggedUserDto>
{
    public string UsernameOrEmail { get; set; }
    public string Password { get; set; }

    public class LoginUserCommandHandler(
        AuthBusinessRules authBusinessRules,
        IJwtProvider jwtProvider,
        IMapper mapper)
        : IRequestHandler<LoginUserCommand, LoggedUserDto>
    {
        public async Task<LoggedUserDto> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            User loggedInUser = await authBusinessRules.CheckUserWithEmailOrUsernameExists(request.UsernameOrEmail);

            await authBusinessRules.CheckIfUserEnteredCorrectPassword(loggedInUser, request.Password);

            TokenResponse tokenResponse = await jwtProvider.CreateTokenAsync(loggedInUser);

            LoggedUserDto loggedUserDto = mapper.Map<LoggedUserDto>(loggedInUser);
            loggedUserDto.AccessToken = tokenResponse.AccessToken;

            return loggedUserDto;
        }
    }
}
