using Core.Persistence.Repositories;
using diDENGE.Application.Services.Repositories;
using diDENGE.Domain.Entities;
using diDENGE.Persistance.Context;

namespace diDENGE.Persistance.Repositories;

public sealed class SocialMediaApplicationUsageRepository :  EfRepositoryBase<SocialMediaApplicationUsage, AppDbContext>, ISocialMediaApplicationUsageRepository
{
    public SocialMediaApplicationUsageRepository(AppDbContext context) : base(context)
    {
    }
}