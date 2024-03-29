using Core.Application.Pipelines.Authorization;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Security.Entities;
using diDENGE.Application.Features.Auths.Rules;
using diDENGE.Application.Features.Users.Commands.UpdateNameSurname;
using diDENGE.Application.Features.Users.Dtos;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace diDENGE.Application.Features.Users.Commands.UpdatePassword;

public class UpdatePasswordCommand : IRequest, ISecuredRequest
{
    public UpdatePasswordCommandBodyDto Body { get; set; }
    public string UserId { get; set; }
    
    public class UpdatePasswordCommandHandler(UserManager<User> userManager, AuthBusinessRules authBusinessRules) : IRequestHandler<UpdatePasswordCommand>
    {
        public async Task Handle(UpdatePasswordCommand request, CancellationToken cancellationToken)
        {
            User updatedUser = await authBusinessRules.CheckUserExistsById(request.UserId);

            var identityResult = await userManager.ChangePasswordAsync(updatedUser, request.Body.OldPassword, request.Body.NewPassword);
            if (!identityResult.Succeeded)
                throw new BusinessException(identityResult.Errors.First().Description);

            await userManager.UpdateSecurityStampAsync(updatedUser);
        }
    }

    public string[] Roles => ["User"];
}