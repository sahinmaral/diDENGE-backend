using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace diDENGE.Domain.Entities;

public class UserAddictionLevel : Entity
{
    public string UserId { get; set; }
    public User User { get; set; }

    public string AddictionLevelId { get; set; }
    public AddictionLevel AddictionLevel { get; set; }

    public double Grade { get; set; }
}