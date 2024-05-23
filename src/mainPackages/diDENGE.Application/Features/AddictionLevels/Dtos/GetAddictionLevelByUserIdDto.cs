namespace diDENGE.Application.Features.AddictionLevels.Dtos;

public class GetAddictionLevelByUserIdDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public double DailyLimit { get; set; }
    public double MinimumGrade { get; set; }
    public double MaximumGrade { get; set; }
    public DateTime CreatedAt { get; set; }
}