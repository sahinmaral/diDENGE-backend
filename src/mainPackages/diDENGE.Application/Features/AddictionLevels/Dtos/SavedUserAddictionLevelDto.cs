namespace diDENGE.Application.Features.AddictionLevels.Dtos;

public class SavedUserAddictionLevelDto
{
    public double Grade { get; set; }
    public AddictionLevelOfSavedUserAddictionLevelDto AddictionLevel { get; set; }
}
public class AddictionLevelOfSavedUserAddictionLevelDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public double DailyLimit { get; set; }
    public double MinimumGrade { get; set; }
    public double MaximumGrade { get; set; }
}