using Core.Persistence.Repositories;
using diDENGE.Application.Services.Repositories;
using diDENGE.Domain.Entities;
using diDENGE.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace diDENGE.Persistance.Repositories;

public sealed class SocialMediaApplicationUsageRepository :  EfRepositoryBase<SocialMediaApplicationUsage, AppDbContext>, ISocialMediaApplicationUsageRepository
{
    private readonly AppDbContext _context;

    public SocialMediaApplicationUsageRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public IQueryable<IGrouping<SocialMediaApplication, SocialMediaApplicationUsage>>
        GetTotalSpendTimeOfSocialMediaApplicationsByCreatedAtAndUserId(string userId, DateTime createdAt)
    {
        return _context.Set<SocialMediaApplicationUsage>()
            .Include(usage => usage.SocialMediaApplication)
            .Where(usage => usage.CreatedAt.Date == createdAt.Date && usage.UserId == userId)
            .GroupBy(usage => usage.SocialMediaApplication);
    }
}