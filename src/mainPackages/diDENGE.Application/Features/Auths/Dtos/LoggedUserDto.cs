using Core.Security.JWT;

namespace diDENGE.Application.Features.Auths.Dtos;

public class LoggedUserDto : TokenResponse
{
    public string Id { get; init; }
    public string FirstName { get; init; }
    public string? MiddleName { get; init; }
    public string LastName { get; init; }
    public DateTime BirthDate { get; init; }
    public string? ProfilePhotoURL { get; init; }
    public string UserName { get; init; }
    public string Email { get; init; }
    public bool IsNewUser { get; set; }
    public LoggedUserAddictionLevelDto AddictionLevel { get; set; }
}

public class LoggedUserAddictionLevelDto
{
    public string Name { get; set; }
    public double DailyLimit { get; set; }
    public double MinimumGrade { get; set; }
    public double MaximumGrade { get; set; }
}