using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Security.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using diDENGE.Application.Features.Auths.Dtos;
using diDENGE.Application.Features.Auths.Rules;
using diDENGE.Application.Services.MessageService;
using diDENGE.Application.Services.Repositories;

namespace diDENGE.Application.Features.Auths.Commands.RegisterUser;

public class RegisterUserCommand : IRequest<RegisterUserResponseDto>
{
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string? ProfilePhotoURL { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }

    public sealed class RegisterUserCommandHandler(
        UserManager<User> userManager,
        AuthBusinessRules authBusinessRules,
        IMapper mapper,
        IUnitOfWork unitOfWork,
        IMessageService messageService)
        : IRequestHandler<RegisterUserCommand, RegisterUserResponseDto>
    {
        public async Task<RegisterUserResponseDto> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            await authBusinessRules.CheckUserWithUsernameAlreadyExists(request.UserName);
            await authBusinessRules.CheckUserWithEmailAlreadyExists(request.Email);
            await authBusinessRules.CheckUserWithPhoneNumberAlreadyExists(request.PhoneNumber);
                
            var response = new RegisterUserResponseDto();
            
            await unitOfWork.ExecuteAsync(async () =>
            {
                User newUser = mapper.Map<User>(request);

                var createUserResult = await userManager.CreateAsync(newUser, request.Password);
                if (!createUserResult.Succeeded)
                {
                    throw new BusinessException("Error during user creation");
                }

                var addToRoleResult = await userManager.AddToRoleAsync(newUser, "User");
                if (!addToRoleResult.Succeeded)
                {
                    throw new BusinessException("Error during adding user to role");
                }

                var sendVerificationCodeResult = await messageService.SendVerificationCodeAsync(request.PhoneNumber);
                if (!sendVerificationCodeResult)
                {
                    throw new BusinessException("Error during sending verification code");
                }
                
                response.UserId = newUser.Id;
            });

            return response;
        }
    }
}