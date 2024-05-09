using diDENGE.Application.Features.Auths.Rules;
using diDENGE.Application.Features.SocialMediaApplicationUsages.Constants;
using diDENGE.Application.Features.SocialMediaApplicationUsages.Dtos;
using diDENGE.Application.Services.Repositories;
using MediatR;

namespace diDENGE.Application.Features.SocialMediaApplicationUsages.Queries.GetSocialMediaApplicationUsagesByStartTime;

public class
    GetSocialMediaApplicationUsagesByStartTimeQuery : IRequest<
    List<List<GetSocialMediaApplicationUsagesByStartTimeDto>>>
{
    public string UserId { get; set; }
    public DateTime StartTime { get; set; }

    public class GetSocialMediaApplicationUsagesByStartTimeQueryHandler(
        AuthBusinessRules authBusinessRules,
        ISocialMediaApplicationUsageRepository repository)
        : IRequestHandler<GetSocialMediaApplicationUsagesByStartTimeQuery,
            List<List<GetSocialMediaApplicationUsagesByStartTimeDto>>>
    {
        public async Task<List<List<GetSocialMediaApplicationUsagesByStartTimeDto>>> Handle(
            GetSocialMediaApplicationUsagesByStartTimeQuery request,
            CancellationToken cancellationToken)
        {
            await authBusinessRules.CheckUserExistsById(request.UserId);
            
            var current = DateTime.Now;
            var startTime = request.StartTime;
            var difference = (current - startTime).Days;

            var gapBetweenDates = difference == SocialMediaApplicationUsageConstants.OneWeekIntervalDivision
                ? SocialMediaApplicationUsageConstants.OneWeekIntervalDivision
                : SocialMediaApplicationUsageConstants.OtherIntervalDivision;

            List<List<GetSocialMediaApplicationUsagesByStartTimeDto>> totalSpendTimeSocialMediaApplicationUsages =
                new List<List<GetSocialMediaApplicationUsagesByStartTimeDto>>();

            for (int i = 0; i < gapBetweenDates; i++)
            {
                var nextDay = startTime.AddDays(i);
                var groupedSpendTimeOfSocialMediaApplicationsByCreatedAt =
                    repository.GetTotalSpendTimeOfSocialMediaApplicationsByCreatedAtAndUserId(request.UserId, nextDay);
                var getSocialMediaApplicationUsagesByStartTimeDtos =
                    groupedSpendTimeOfSocialMediaApplicationsByCreatedAt.Select(usage =>
                        new GetSocialMediaApplicationUsagesByStartTimeDto()
                        {
                            PackageName = usage.Key.PlaystoreId,
                            Name = usage.Key.Name,
                            TotalSpendTime = usage.Sum(grouped => grouped.SpentTime),
                            CreatedAt = nextDay
                        }).OrderBy(usage => usage.Name).ToList();

                totalSpendTimeSocialMediaApplicationUsages.Add(getSocialMediaApplicationUsagesByStartTimeDtos);
            }

            return totalSpendTimeSocialMediaApplicationUsages;
        }
    }
}