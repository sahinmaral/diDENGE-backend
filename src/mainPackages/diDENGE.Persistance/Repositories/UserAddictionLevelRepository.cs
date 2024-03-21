using Core.Persistence.Repositories;
using diDENGE.Application.Services.Repositories;
using diDENGE.Domain.Entities;
using diDENGE.Persistance.Context;

namespace diDENGE.Persistance.Repositories;

public sealed class UserAddictionLevelRepository :  EfRepositoryBase<UserAddictionLevel, AppDbContext>, IUserAddictionLevelRepository
{
    public UserAddictionLevelRepository(AppDbContext context) : base(context)
    {
    }
}