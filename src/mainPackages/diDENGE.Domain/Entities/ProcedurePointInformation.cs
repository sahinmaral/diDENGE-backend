using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace diDENGE.Domain.Entities;

public class ProcedurePointInformation : Entity
{
    public string UserId { get; set; }
    public User User { get; set; }

    public string AddictionLevelId { get; set; }
    public AddictionLevel AddictionLevel { get; set; }

    public string ProcedureId { get; set; }
    public Procedure Procedure { get; set; }
    
    public double OverallGrade { get; set; }

    public int Count { get; set; }
}