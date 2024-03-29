using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using diDENGE.Application.Services.FileStorage;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace diDENGE.Infrastructure.FileStorage;

public class CloudinaryService : ICloudinaryService
{
    private readonly Cloudinary _cloudinary;
    
    public CloudinaryService(IOptions<CloudinaryOptions> cloudinaryOptions)
    {
        CloudinaryOptions cloudinaryOptionsValue = cloudinaryOptions.Value;

        Account account = new Account(
            cloudinaryOptionsValue.CloudName,
            cloudinaryOptionsValue.APIKey,
            cloudinaryOptionsValue.APISecret
        );

        _cloudinary = new Cloudinary(account);
    }

    public async Task<ImageUploadResult> UploadImageAsync(IFormFile file, CancellationToken cancellationToken)
    {
        var uploadParams = new ImageUploadParams
        {
            File = new FileDescription(file.FileName, file.OpenReadStream()),
            Folder = "diDENGE/profileImages",
            PublicId = Guid.NewGuid().ToString()
        };

        return await _cloudinary.UploadAsync(uploadParams);
    }

    public async Task<DeletionResult?> DeleteImageAsync(string publicId, CancellationToken cancellationToken)
    {
        var deletionParams = new DeletionParams(publicId)
        {
            ResourceType = ResourceType.Image
        };

        return await _cloudinary.DestroyAsync(deletionParams);
    }
}
