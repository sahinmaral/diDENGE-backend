using Core.Persistence.Repositories;
using diDENGE.Application.Services.Repositories;
using diDENGE.Domain.Entities;
using diDENGE.Persistance.Context;

namespace diDENGE.Persistance.Repositories;

public sealed class ProcedurePointInformationRepository :  EfRepositoryBase<ProcedurePointInformation, AppDbContext>, IProcedurePointInformationRepository
{
    public ProcedurePointInformationRepository(AppDbContext context) : base(context)
    {
    }
}