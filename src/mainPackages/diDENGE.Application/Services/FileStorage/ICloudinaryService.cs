
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace diDENGE.Application.Services.FileStorage;

public interface ICloudinaryService
{
    Task<ImageUploadResult> UploadImageAsync(IFormFile file, CancellationToken cancellationToken);
    Task<DeletionResult?> DeleteImageAsync(string publicId, CancellationToken cancellationToken);
}