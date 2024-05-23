using System.Linq.Expressions;
using Core.Persistence.Repositories;
using diDENGE.Application.Services.Repositories;
using diDENGE.Domain.Entities;
using diDENGE.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace diDENGE.Persistance.Repositories;

public sealed class SocialMediaApplicationUsageRepository : EfRepositoryBase<SocialMediaApplicationUsage, AppDbContext>,
    ISocialMediaApplicationUsageRepository
{
    private readonly AppDbContext _context;

    public SocialMediaApplicationUsageRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public IQueryable<IGrouping<SocialMediaApplication, SocialMediaApplicationUsage>>
        GetTotalSpendTimeOfSocialMediaApplicationsByStartAndEndTimeAndUserId(string userId, DateTime startTime,
            DateTime? endTime)
    {
        if (!endTime.HasValue)
        {
            Expression<Func<SocialMediaApplicationUsage, bool>> expressionWithStartTime = usage =>
                usage.CreatedAt.Date >= startTime && usage.UserId == userId;

            return _context.Set<SocialMediaApplicationUsage>()
                .Include(usage => usage.SocialMediaApplication)
                .Where(expressionWithStartTime)
                .GroupBy(usage => usage.SocialMediaApplication);
        }

        Expression<Func<SocialMediaApplicationUsage, bool>> expressionWithStartAndEndTime = usage =>
            usage.CreatedAt.Date >= startTime && usage.CreatedAt.Date < endTime.Value.AddDays(1)
                                              && usage.UserId == userId;

        return _context.Set<SocialMediaApplicationUsage>()
            .Include(usage => usage.SocialMediaApplication)
            .Where(expressionWithStartAndEndTime)
            .GroupBy(usage => usage.SocialMediaApplication);
    }
}