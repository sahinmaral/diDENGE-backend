namespace diDENGE.Application.Features.SocialMediaApplicationUsages.Dtos;

public record AddSocialMediaApplicationUsageDto(
    string PackageName, 
    int OpenCount, 
    int TotalTimeInForeground);
