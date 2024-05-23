namespace diDENGE.Application.Features.SocialMediaApplicationUsages.Dtos;

public class GetSocialMediaApplicationUsagesByStartAndEndTimeDto
{
    public string Name { get; set; }
    public string PackageName { get; set; }
    public double TotalSpendTime { get; set; }
    public int OpeningCount { get; set; }
    public DateTime Date { get; set; }
}