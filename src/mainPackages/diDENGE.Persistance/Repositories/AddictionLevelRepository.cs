using Core.Persistence.Repositories;
using diDENGE.Application.Services.Repositories;
using diDENGE.Domain.Entities;
using diDENGE.Persistance.Context;

namespace diDENGE.Persistance.Repositories;

public sealed class AddictionLevelRepository :  EfRepositoryBase<AddictionLevel, AppDbContext>, IAddictionLevelRepository
{
    public AddictionLevelRepository(AppDbContext context) : base(context)
    {
    }
}