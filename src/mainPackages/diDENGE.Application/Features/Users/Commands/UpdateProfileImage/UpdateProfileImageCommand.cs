using Core.Security.Entities;
using diDENGE.Application.Features.Auths.Rules;
using diDENGE.Application.Features.Users.Dtos;
using diDENGE.Application.Services.FileStorage;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace diDENGE.Application.Features.Users.Commands.UpdateProfileImage;

public class UpdateProfileImageCommand : IRequest<UpdatedProfileImageDto>
{
    public string UserId { get; set; }
    public IFormFile Image { get; set; }
    
    public class UpdateProfileImageCommandHandler(
        UserManager<User> userManager,
        AuthBusinessRules authBusinessRules,
        ICloudinaryService cloudinaryService) : IRequestHandler<UpdateProfileImageCommand,UpdatedProfileImageDto>
    {
        public async Task<UpdatedProfileImageDto> Handle(UpdateProfileImageCommand request, CancellationToken cancellationToken)
        {
            User updatedUser = await authBusinessRules.CheckUserExistsById(request.UserId);

            if (updatedUser.ProfilePhotoURL is not null)
            {
                var deletingOldImageResult = await cloudinaryService.DeleteImageAsync(
                    ConvertPhotoPathToPublicId(updatedUser.ProfilePhotoURL), 
                    cancellationToken);
            }

            var uploadedImageResult = await cloudinaryService.UploadImageAsync(request.Image, cancellationToken);
            string uploadedImagePath = $"{uploadedImageResult.FullyQualifiedPublicId}.{uploadedImageResult.Format}";

            updatedUser.ProfilePhotoURL = uploadedImagePath;

            await userManager.UpdateAsync(updatedUser);

            return new UpdatedProfileImageDto() { NewProfileImagePath = uploadedImagePath };
        }
        
        private string ConvertPhotoPathToPublicId(string photoPath)
        {
            string modifiedString = photoPath.Replace("image/upload/", "");
            int dotIndex = modifiedString.IndexOf('.');
            modifiedString = modifiedString.Substring(0, dotIndex);
            return modifiedString;
        }
    }
}