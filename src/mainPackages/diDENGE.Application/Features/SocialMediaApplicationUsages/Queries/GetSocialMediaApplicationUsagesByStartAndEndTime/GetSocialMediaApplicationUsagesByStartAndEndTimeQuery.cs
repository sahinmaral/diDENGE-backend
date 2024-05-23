using diDENGE.Application.Features.Auths.Rules;
using diDENGE.Application.Features.SocialMediaApplicationUsages.Constants;
using diDENGE.Application.Features.SocialMediaApplicationUsages.Dtos;
using diDENGE.Application.Services.Repositories;
using MediatR;

namespace diDENGE.Application.Features.SocialMediaApplicationUsages.Queries.
    GetSocialMediaApplicationUsagesByStartAndEndTime;

public class
    GetSocialMediaApplicationUsagesByStartAndEndTimeQuery : IRequest<
    List<List<GetSocialMediaApplicationUsagesByStartAndEndTimeDto>>>
{
    public string UserId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }

    public class GetSocialMediaApplicationUsagesByStartAndEndTimeQueryHandler(
        AuthBusinessRules authBusinessRules,
        ISocialMediaApplicationRepository socialMediaApplicationRepository,
        ISocialMediaApplicationUsageRepository socialMediaApplicationUsageRepository)
        : IRequestHandler<GetSocialMediaApplicationUsagesByStartAndEndTimeQuery,
            List<List<GetSocialMediaApplicationUsagesByStartAndEndTimeDto>>>
    {
        public async Task<List<List<GetSocialMediaApplicationUsagesByStartAndEndTimeDto>>> Handle(
            GetSocialMediaApplicationUsagesByStartAndEndTimeQuery request,
            CancellationToken cancellationToken)
        {
            await authBusinessRules.CheckUserExistsById(request.UserId);

            var endTime = request.EndTime.HasValue ? request.EndTime.Value.Date : DateTime.Now.Date;
            var startTime = request.StartTime.Date;
            var difference = (endTime - startTime).Days;

            int gapBetweenDates;
            if (difference < SocialMediaApplicationUsageConstants.OneWeekIntervalDivision)
            {
                gapBetweenDates = difference;
            }
            else if (difference == SocialMediaApplicationUsageConstants.OneWeekIntervalDivision)
            {
                gapBetweenDates = SocialMediaApplicationUsageConstants.OneWeekIntervalDivision;
            }
            else
            {
                gapBetweenDates = SocialMediaApplicationUsageConstants.OtherIntervalDivision;
            }

            List<List<GetSocialMediaApplicationUsagesByStartAndEndTimeDto>> totalSpendTimeSocialMediaApplicationUsages =
                new List<List<GetSocialMediaApplicationUsagesByStartAndEndTimeDto>>();

            for (int i = 0; i < gapBetweenDates; i++)
            {
                int intervalValue = gapBetweenDates is SocialMediaApplicationUsageConstants.OneWeekIntervalDivision or 1
                    ? 1
                    : difference / SocialMediaApplicationUsageConstants.OtherIntervalDivision;
                
                int nextDayAddValue = gapBetweenDates == SocialMediaApplicationUsageConstants.OneWeekIntervalDivision
                    ? i
                    : (i + 1) * intervalValue;
                
                var nextDay = startTime.AddDays(nextDayAddValue);
                var groupedSpendTimeOfSocialMediaApplicationsByCreatedAt =
                    socialMediaApplicationUsageRepository
                        .GetTotalSpendTimeOfSocialMediaApplicationsByStartAndEndTimeAndUserId(request.UserId, nextDay,
                            nextDay).ToList();

                if (groupedSpendTimeOfSocialMediaApplicationsByCreatedAt.Count == 0)
                {
                    var getSocialMediaApplicationUsagesByStartAndEndTimeDtos =
                        await SetAllSocialMediaApplicationUsagesAsZeroAndReturn(nextDay);
                    totalSpendTimeSocialMediaApplicationUsages.Add(
                        getSocialMediaApplicationUsagesByStartAndEndTimeDtos);
                }
                else
                {
                    var getSocialMediaApplicationUsagesByStartAndEndTimeDtos =
                        groupedSpendTimeOfSocialMediaApplicationsByCreatedAt.Select(usage =>
                            new GetSocialMediaApplicationUsagesByStartAndEndTimeDto()
                            {
                                PackageName = usage.Key.PlaystoreId,
                                Name = usage.Key.Name,
                                TotalSpendTime = usage.Sum(grouped => grouped.SpentTime),
                                Date = nextDay
                            }).OrderBy(usage => usage.Name).ToList();

                    totalSpendTimeSocialMediaApplicationUsages.Add(
                        getSocialMediaApplicationUsagesByStartAndEndTimeDtos);
                }
            }

            return totalSpendTimeSocialMediaApplicationUsages;
        }

        private async Task<List<GetSocialMediaApplicationUsagesByStartAndEndTimeDto>>
            SetAllSocialMediaApplicationUsagesAsZeroAndReturn(DateTime nextDay)
        {
            var allSocialMediaApplicationCount = await socialMediaApplicationRepository.CountAsync();
            var allSocialMediaApplication =
                (socialMediaApplicationRepository.GetList(size: allSocialMediaApplicationCount)).Items;
            return allSocialMediaApplication.Select((app) => new GetSocialMediaApplicationUsagesByStartAndEndTimeDto()
            {
                PackageName = app.PlaystoreId,
                Name = app.Name,
                TotalSpendTime = 0,
                Date = nextDay
            }).ToList();
        }
    }
}