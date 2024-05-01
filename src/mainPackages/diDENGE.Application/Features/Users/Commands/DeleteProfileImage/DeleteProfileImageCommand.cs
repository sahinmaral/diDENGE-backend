using Core.CrossCuttingConcerns.Exceptions;
using Core.Security.Entities;
using diDENGE.Application.Features.Auths.Rules;
using diDENGE.Application.Features.Users.Helpers;
using diDENGE.Application.Services.FileStorage;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace diDENGE.Application.Features.Users.Commands.DeleteProfileImage;

public class DeleteProfileImageCommand : IRequest
{
    public string UserId { get; set; }

    public class DeleteProfileImageCommandHandler(
        UserManager<User> userManager,
        AuthBusinessRules authBusinessRules, 
        ICloudinaryService cloudinaryService) : IRequestHandler<DeleteProfileImageCommand>
    {
        public async Task Handle(DeleteProfileImageCommand request, CancellationToken cancellationToken)
        {
            User updatedUser = await authBusinessRules.CheckUserExistsById(request.UserId);

            if (updatedUser.ProfilePhotoURL is null)
                throw new BusinessException("User didn't upload any profile image yet");
            
            var deletingProfileImageResult = await cloudinaryService.DeleteImageAsync(
                UserHelpers.ConvertPhotoPathToPublicId(updatedUser.ProfilePhotoURL), 
                cancellationToken);

            updatedUser.ProfilePhotoURL = null;

            await userManager.UpdateAsync(updatedUser);
        }
    }
}