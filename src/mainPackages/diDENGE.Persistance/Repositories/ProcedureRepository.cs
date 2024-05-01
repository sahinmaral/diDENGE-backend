using Core.Persistence.Repositories;
using diDENGE.Application.Services.Repositories;
using diDENGE.Domain.Entities;
using diDENGE.Persistance.Context;

namespace diDENGE.Persistance.Repositories;

public sealed class ProcedureRepository :  EfRepositoryBase<Procedure, AppDbContext>, IProcedureRepository
{
    public ProcedureRepository(AppDbContext context) : base(context)
    {
    }
}