namespace diDENGE.Application.Features.Users.Dtos;

public record UpdateDoNotDisturbStatusCommandBodyDto(bool IsDoNotDisturbEnabled, DateTime? DoNotDisturbExpires);