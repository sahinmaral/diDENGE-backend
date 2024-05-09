using Microsoft.AspNetCore.Identity;

namespace Core.Security.Entities;

public class User : IdentityUser<string>
{
    public User()
    {
        Id = Guid.NewGuid().ToString();
    }
    public override string Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string? MiddleName { get; set; }
    public string LastName { get; set; } = null!;
    public DateTime BirthDate { get; set; }
    public string? ProfilePhotoURL { get; set; }
    public bool IsNewUser { get; set; } = true;
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpires { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public bool IsDoNotDisturbEnabled { get; set; } = false;
    public DateTime? DoNotDisturbExpires { get; set; }
}
