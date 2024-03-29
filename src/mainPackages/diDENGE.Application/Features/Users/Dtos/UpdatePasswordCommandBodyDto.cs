namespace diDENGE.Application.Features.Users.Dtos;

public record UpdatePasswordCommandBodyDto(string OldPassword, string NewPassword);