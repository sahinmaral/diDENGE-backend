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

public partial class RegisterUserCommand : IRequest<RegisteredUserDto>
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

    public sealed class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, RegisteredUserDto>
    {
        private readonly UserManager<User> _userManager;
        private readonly AuthBusinessRules _authBusinessRules;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMessageService _messageService;

        public RegisterUserCommandHandler(UserManager<User> userManager,
            AuthBusinessRules authBusinessRules,
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IMessageService messageService)
        {
            _userManager = userManager;
            _authBusinessRules = authBusinessRules;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _messageService = messageService;
        }

        public async Task<RegisteredUserDto> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            await _authBusinessRules.CheckUserWithUsernameAlreadyExists(request.UserName);
            await _authBusinessRules.CheckUserWithEmailAlreadyExists(request.Email);
            await _authBusinessRules.CheckUserWithPhoneNumberAlreadyExists(request.PhoneNumber);

            RegisteredUserDto registeredUserDto = null;

            await _unitOfWork.ExecuteAsync(async () =>
            {
                User newUser = _mapper.Map<User>(request);

                var createUserResult = await _userManager.CreateAsync(newUser, request.Password);
                if (!createUserResult.Succeeded)
                {
                    throw new BusinessException("Error during user creation");
                }

                var addToRoleResult = await _userManager.AddToRoleAsync(newUser, "User");
                if (!addToRoleResult.Succeeded)
                {
                    throw new BusinessException("Error during adding user to role");
                }

                var sendVerificationCodeResult = await _messageService.SendVerificationCodeAsync(request.PhoneNumber);
                if (!sendVerificationCodeResult)
                {
                    throw new BusinessException("Error during sending verification code");
                }

                registeredUserDto = _mapper.Map<RegisteredUserDto>(newUser);
            });

            return registeredUserDto;
        }
    }
}