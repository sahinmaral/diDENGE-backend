using Core.Persistence.Repositories;
using diDENGE.Domain.Entities;

namespace diDENGE.Application.Services.Repositories;

public interface IProcedurePointInformationRepository : IAsyncRepository<ProcedurePointInformation>, IRepository<ProcedurePointInformation>
{ 
    
}