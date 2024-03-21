using Core.Persistence.Repositories;

namespace diDENGE.Domain.Entities;

public class SocialMediaApplication : Entity
{
    public string Name { get; set; }
    public string PlaystoreId { get; set; }
}