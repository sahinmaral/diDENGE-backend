using Core.Persistence.Repositories;
using diDENGE.Application.Services.Repositories;
using diDENGE.Domain.Entities;
using diDENGE.Persistance.Context;

namespace diDENGE.Persistance.Repositories;

public sealed class SocialMediaApplicationRepository :  EfRepositoryBase<SocialMediaApplication, AppDbContext>, ISocialMediaApplicationRepository
{
    public SocialMediaApplicationRepository(AppDbContext context) : base(context)
    {
    }
}