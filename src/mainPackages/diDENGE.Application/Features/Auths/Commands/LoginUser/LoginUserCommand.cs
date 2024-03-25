using AutoMapper;
using Core.Security.Entities;
using Core.Security.JWT;
using diDENGE.Application.Features.Auths.Dtos;
using diDENGE.Application.Features.Auths.Rules;
using diDENGE.Application.Services.Repositories;
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
        IMapper mapper,
        IUserAddictionLevelRepository userAddictionLevelRepository)
        : IRequestHandler<LoginUserCommand, LoggedUserDto>
    {
        public async Task<LoggedUserDto> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            User loggedInUser = await authBusinessRules.CheckUserWithEmailOrUsernameExists(request.UsernameOrEmail);

            await authBusinessRules.CheckIfUserEnteredCorrectPassword(loggedInUser, request.Password);

            var userAddictionLevel = await userAddictionLevelRepository.GetDetailedAsync(
                predicate:x => x.UserId == loggedInUser.Id,
                include: levels => levels.Include(l => l.AddictionLevel) 
                );
            var mappedUserAddictionLevel = mapper.Map<LoggedUserAddictionLevelDto>(userAddictionLevel);

            //TODO: E-posta doğrulaması yerine telefon numarası doğrulaması yapılabilir
            //await _authBusinessRules.CheckIfUserEmailHasBeenVerified(loggedInUser);

            TokenResponse tokenResponse = await jwtProvider.CreateTokenAsync(loggedInUser);

            LoggedUserDto loggedUserDto = mapper.Map<LoggedUserDto>(loggedInUser);
            loggedUserDto.AccessToken = tokenResponse.AccessToken;
            loggedUserDto.RefreshToken = tokenResponse.RefreshToken;
            loggedUserDto.RefreshTokenExpires = tokenResponse.RefreshTokenExpires;
            loggedUserDto.AddictionLevel = mappedUserAddictionLevel;

            return loggedUserDto;
        }
    }
}
