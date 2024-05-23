using Core.Persistence.Repositories;
using diDENGE.Domain.Entities;

namespace diDENGE.Application.Services.Repositories;

public interface ISocialMediaApplicationUsageRepository : IAsyncRepository<SocialMediaApplicationUsage>, IRepository<SocialMediaApplicationUsage>
{
    public IQueryable<IGrouping<SocialMediaApplication, SocialMediaApplicationUsage>>
        GetTotalSpendTimeOfSocialMediaApplicationsByStartAndEndTimeAndUserId(string userId, DateTime startTime,
            DateTime? endTime = null);
}