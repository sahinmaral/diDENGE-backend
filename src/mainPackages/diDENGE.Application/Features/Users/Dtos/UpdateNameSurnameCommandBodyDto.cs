namespace diDENGE.Application.Features.Users.Dtos;

public record UpdateNameSurnameCommandBodyDto(string FirstName, string LastName, string? MiddleName);