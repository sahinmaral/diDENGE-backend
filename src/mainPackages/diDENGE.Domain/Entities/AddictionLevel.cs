using Core.Persistence.Repositories;

namespace diDENGE.Domain.Entities;

public class AddictionLevel : Entity
{
    public string Name { get; set; }
    public double DailyLimit { get; set; }
    public double MinimumGrade { get; set; }
    public double MaximumGrade { get; set; }
}